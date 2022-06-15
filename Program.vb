Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports xsd_to_vb_class.WorkDay

Module Module1

    ''' <summary>
    ''' This is not amazing code! Jessa just needed code to write code! But she offers it for making
    ''' consistent VB class code for Workday XML serializing in the future! There are other XSD to VB 
    ''' class code generators out there, but Jessa didn't like the results. 
    ''' </summary>
    Sub Main()
        ' Generate the file of vb classes
        Dim xsdFilePath As String = "C:\Users\jwright\Documents\MyGithub\xsd-to-vb-class\xsd-to-vb-class\Xsd\Get_Applicants_Response_Schema.xml"
        Dim vbClassFileDirectory As String = "C:\Users\jwright\Documents\MyGithub\xsd-to-vb-class\xsd-to-vb-class\VbClassFileOutput\"
        'GenerateVbClasses(xsdFilePath, vbClassFileDirectory)


        ' Test the deserialization of sample XML based on those classes
        Dim xmlFilePath As String = "C:\Users\jwright\Documents\MyGithub\xsd-to-vb-class\xsd-to-vb-class\SampleXml\Sample_Get_Applicants_Response.xml"
        Dim deserialized As WorkdayXmlEnvelope
       deserialized = Deserialize(xmlFilePath)

        ' Test the serialization by serializing back to a string, slammed in a file in 
        ' the specified location
        ' Then you can compare the XML in to the XML out.
        Dim serialized As String = String.Empty
        Dim serializedFileDir As String = "C:\Users\jwright\Documents\MyGithub\xsd-to-vb-class\xsd-to-vb-class\SerializedXml\"
        serialized = serialized = Serialize(deserialized, serializedFileDir)

    End Sub


    ''' <summary>
    ''' This generates a txt file of vb classes from an XSD file. This was made specifically to 
    ''' generate the classes as Jessa wanted them annotated for Workday. 
    ''' 1. Get the sample XML from Workday for whatever you are working with. Save it in a place.
    ''' 2. Run the Visual Studio XML Schema definition tool to generate an XSD file. 
    '''     In VS -> Tools -> Command Line -> Developer Command Prompt
    '''     In the command prompt, in the directory of your XML file:
    '''     `xsd {XML file name}`
    '''     That will drop an XSD file in that directory with the same name as your XML file.    
    ''' 3. Rename the XSD file to something with an XML file extension and put it in a place. We will
    '''     call this the schema XML. (An XSD should be valid XML. If you have an XSD in your solution, 
    '''     VS will do weird stuff with it that Jessa doesn't want to deal with.)
    ''' 4. Set the params according to the location of your schema XML file and where you want the output file.
    ''' 5. The name of the resulting file of vb classes is yyyy-MM-dd__hh-mm__vb-class.txt.
    '''     The resulting file of vb classes will only have the classes; no imports or namespaces. 
    '''     It will likely need refining; protected names aren't addressed here, mistakes are made, 
    '''     type names aren't always capitalized, constructors aren't included.
    ''' </summary>
    ''' <param name="XsdFilePath">File path for the input XSD file.</param>
    ''' <param name="VbClassFileDirectory">File directory for the output vb class file.</param>
    Sub GenerateVbClasses(ByVal XsdFilePath As String, ByVal VbClassFileDirectory As String)
        
        Dim sr As New StreamReader(XsdFilePath)

        Dim settings As XmlReaderSettings = New XmlReaderSettings()
        Dim reader As XmlReader = XmlReader.Create(sr, settings)
        Dim doc As New XmlDocument()
        doc.Load(reader)

        Dim model As New List(Of Element)
        Dim list As XmlNodeList = doc.ChildNodes()

        Dim schemaNode As XmlNode

        For Each node In list
            If node.LocalName = "schema"
                schemaNode = node
                Exit For
            End If
        Next

        ' Master element list will hold all the elements that need their own class defs
        Dim masterElementList As List(Of Element) = New List(Of Element)

        model = ReadElements(schemaNode, New Element(), masterElementList)

        WriteVbClassCode(masterElementList, VbClassFileDirectory)       

    End Sub


    Public Function ReadElements(ByVal Node As XmlNode, ByVal ParentElement As Element, ByRef MasterElementList As List(Of Element)) As List(Of Element)
        Dim elementList As New List(Of Element)
        ' for each element described
        '    collect the child elements
        '       for each child element, check if they need to be added as their own element, recurse if so
        '    collect the attributes

        For Each childNode In Node
            Dim childElement As Element = New Element()
            Dim attNodeList
            If childNode.Name = "xs:element"

                'element info                               

                Dim name As String = childElement.ElementName
                If childNode.Attributes("name") IsNot Nothing
                    name = childNode.Attributes("name").Value
                End If

                If String.IsNullOrWhiteSpace(name)
                    If childNode.Attributes("ref") IsNot Nothing
                        name = childNode.Attributes("ref").Value
                        childElement.Ref = True
                    End If
                End If

                childElement.ElementName = name

                If childElement.ElementName = "ID"
                    Dim pause As Boolean = true
                End If

                Dim minOccurs As String = String.Empty
                If childNode.Attributes("minOccurs") IsNot Nothing
                    minOccurs = childNode.Attributes("minOccurs").Value
                    If minOccurs = "0"
                        childElement.Opt = true
                    End If
                End If

                Dim maxOccurs As String = String.Empty
                If childNode.Attributes("maxOccurs") IsNot Nothing
                    maxOccurs = childNode.Attributes("maxOccurs").Value
                    If maxOccurs = "unbounded"
                        childElement.Multiple = True
                    End If
                End If

                Dim type As String = String.Empty
                If childNode.Attributes("type") IsNot Nothing
                    type = childNode.Attributes("type").Value.Replace("xs:", "")
                    childElement.Type = type
                End If

                Dim order As String = String.Empty
                If childNode.Attributes("msdata:Ordinal") IsNot Nothing
                    childElement.Order = childNode.Attributes("msdata:Ordinal").Value
                End If

                childElement.ChildOf = ParentElement.ElementName

                'does this element have children?
                If Node.HasChildNodes
                    If String.IsNullOrWhiteSpace(childElement.Type)
                        childElement.Type = childElement.ElementName
                    End If

                    Dim grandchildNode As XmlNode = nothing

                    If childNode.FirstChild IsNot Nothing AndAlso childNode.FirstChild.Name = "xs:complexType"
                        If childNode.FirstChild.FirstChild IsNot Nothing
                            If childNode.FirstChild.FirstChild.Name = "xs:sequence"
                                grandchildNode = childNode.FirstChild.FirstChild
                            ElseIf childNode.FirstChild.FirstChild.Name = "xs:simpleContent" 


                                If childNode.FirstChild.FirstChild.FirstChild IsNot Nothing AndAlso childNode.FirstChild.FirstChild.FirstChild.Name = "xs:extension"
                                    attNodeList = childNode.FirstChild.FirstChild.FirstChild.ChildNodes
                                End If
                            End If
                        End If
                    End If

                    If grandchildNode IsNot Nothing
                        childElement.Children = ReadElements(grandchildNode, childElement, MasterElementList)
                    End If

                End If

                ' attribute info
                Dim attNode As XmlNode
                

                If childNode.FirstChild IsNot Nothing AndAlso childNode.FirstChild.Name = "xs:complexType"

                    If childNode.FirstChild.FirstChild IsNot Nothing
                        If childNode.FirstChild.FirstChild.Name = "xs:sequence"
                            attNodeList = childNode.FirstChild.ChildNodes
                        ElseIf childNode.FirstChild.FirstChild.Name = "xs:simpleContent"
                            If childNode.FirstChild.FirstChild.Attributes("msdata:ColumnName") IsNot Nothing
                                childElement.SimpleContentName = childNode.FirstChild.FirstChild.Attributes("msdata:ColumnName").Value
                            End If 
                            If childNode.FirstChild.FirstChild.FirstChild IsNot Nothing AndAlso childNode.FirstChild.FirstChild.FirstChild.Name = "xs:extension"
                                attNodeList = childNode.FirstChild.FirstChild.FirstChild.ChildNodes
                            End If
                        End If

                    End If

                End If
                
                Dim newAtt As Attribute
                If attNodeList IsNot Nothing AndAlso attNodeList.Count() > 0

                    For Each attNode In attNodeList
                        If attNode.Name = "xs:attribute"
                            newAtt = New Attribute()

                            If attNode.Attributes("name") IsNot Nothing
                                newAtt.Name = attNode.Attributes("name").Value
                            End If

                            If attNode.Attributes("type") IsNot Nothing
                                newAtt.Type = attNode.Attributes("type").Value.Replace("xs:", "")
                            End If

                            childElement.Attributes.Add(newAtt)
                        End If
                    Next

                End If


            ElseIf childNode.Name = "xs:attribute"
                ' these attributes belong to the parent node


            End If

            elementList.Add(childElement)

            If childElement.ElementName = childElement.Type AndAlso Not childElement.Ref

                Dim exists As Boolean = MasterElementList.Exists(Function(x) x.ElementName = childElement.ElementName)

                If Not exists
                    MasterElementList.Add(childElement)
                End If

            End If

        Next


        Return elementList

    End Function    
    Public Sub WriteVbClassCode(ByVal MasterElementList As List(Of Element), ByVal VbClassFileDirectory As String) 
        ' use the info in that model to write the vb class code. 
        Dim sb As New StringBuilder()
        Dim wdns As String = "urn:com.workday/bsvc"
        Dim modelElement As Element
        Dim childElement As Element
        Dim attribute As Attribute


        For Each modelElement In MasterElementList


            ' make the class
            sb.AppendLine(String.Format("<XmlRoot(ElementName:=""{0}"", Namespace:=""{1}"")>", modelElement.ElementName, wdns))
            sb.AppendLine(String.Format("Public Class {0}", modelElement.ElementName))
            sb.AppendLine(String.Empty)

            ' add the attributes
            For Each attribute In modelElement.Attributes
                sb.AppendLine(String.Format("{0}<XmlAttribute(AttributeName:=""{1}"", Namespace:=""{2}"", Form:=XmlSchemaForm.Qualified)>", vbTab, attribute.Name, wdns))
                sb.AppendLine(String.Format("{0}Public Property {1} As {2}", vbTab, attribute.Name, attribute.Type))
                sb.AppendLine(String.Empty)

            Next

            ' add the elements
            For Each childElement In modelElement.Children
                Dim name As String = childElement.ElementName
                Dim type As String = childElement.Type

                If childElement.Multiple
                    name &= "()"
                    type &= "()"
                End If

                'Dim orderRule As String = String.Empty
                'orderRule = String.Format(", Order:={0}", childElement.Order)

                sb.AppendLine(String.Format("{0}<XmlElement(ElementName:=""{1}"", Namespace:=""{2}"")>", vbTab, childElement.ElementName, wdns))
                sb.AppendLine(String.Format("{0}Public Property {1} As {2}", vbTab, name, type))
                sb.AppendLine(String.Empty)

            Next

            ' add any simplecontent
            If Not String.IsNullOrWhiteSpace(modelElement.SimpleContentName)
                sb.AppendLine(String.Format("{0}<XmlText>", vbTab))
                sb.AppendLine(String.Format("{0}Public Property {1} As String", vbTab, modelElement.SimpleContentName))
                sb.AppendLine(String.Empty)
            End If

            ' close the class
            sb.AppendLine("End Class")
            sb.AppendLine(String.Empty)
            sb.AppendLine(String.Empty)


        Next

        Dim fileName As String = VbClassFileDirectory & Date.Now.ToString("yyyy-MM-dd__hh-mm") + "__vb-class.txt"
        File.WriteAllText(fileName, sb.ToString())
    End Sub

    Public Function Deserialize(ByVal InputXmlFilePath As String) As WorkdayXmlEnvelope

        Dim result As New WorkdayXmlEnvelope()

        Dim serializer As XmlSerializer = New XmlSerializer((New WorkdayXmlEnvelope()).GetType())
       
        Dim stream As New StreamReader(InputXmlFilePath)
        Dim sr As StringReader = New StringReader(stream.ReadToEnd())

        result = serializer.Deserialize(sr)

        Return result
    End Function

    Public Function Serialize(ByVal Model As WorkdayXmlEnvelope, ByVal SerializedXmlFileDir As String) As String

        Dim xmlString
        Dim serializer As XmlSerializer
        Dim stringWriter As New StringWriterUtf8
        Dim xmlWriter As System.Xml.XmlWriter
        xmlWriter = System.Xml.XmlWriter.Create(stringWriter, WorkdayXmlConstants.WorkdayXmlWriterSettings)
        serializer = New XmlSerializer(Model.GetType())
        serializer.Serialize(xmlWriter, Model, WorkdayXmlConstants.WorkdayXmlNamespaces)
        xmlWriter.Close()

        xmlString = stringWriter.ToString()



        Dim fileName As String = SerializedXmlFileDir & Date.Now.ToString("yyyy-MM-dd__hh-mm") + "__serialized-xml.xml"
        File.WriteAllText(fileName, xmlString)

        Return xmlString
    End Function


End Module
