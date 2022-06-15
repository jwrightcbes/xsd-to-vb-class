Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization


Module Program   

    ''' <summary>
    ''' This is not amazing code! Jessa just needed code to write code! But she offers it for making
    ''' consistent VB class code for Workday XML serializing in the future! There are other XSD to VB 
    ''' class code generators out there, but Jessa didn't like the results. 
    ''' </summary>
    Sub Main()
        ' Generate the file of vb classes
        Dim xsdFilePath As String = "C:\Users\jwright\Documents\_local-repos\xsd-to-vb-class\xsd-to-vb-class\Xsd\Get_Applicants_Response.xsd"
        Dim vbClassFileDirectory As String = "C:\Users\jwright\Documents\_local-repos\xsd-to-vb-class\VbClassFileOutput"
        GenerateVbClasses(xsdFilePath, vbClassFileDirectory)

        ' Test the deserialization of sample XML based on those classes

        ' Test the serialization of samply XML based on those classes
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
    '''     This XSD file is what GenerateVbClasses() accepts as the input XSD file.
    ''' 3. Set the params according to the location of your XSD file and where you want the output file.
    ''' 4. The name of the resulting file of vb classes is yyyy-MM-dd__hh-mm__vb-class.txt.
    '''     The resulting file of vb classes will only have the classes; no imports or namespaces. 
    '''     It will likely need refining; protected names aren't addressed here, mistakes are made, 
    '''     type names aren't always capitalized, constructors aren't included.
    ''' </summary>
    ''' <param name="XsdFilePath">File path for the input XSD file.</param>
    ''' <param name="VbClassFileDirectory">File directory for the output vb class file.</param>
    Sub GenerateVbClasses(ByVal XsdFilePath As String, ByVal VbClassFileDirectory As String)

        Dim sb As New StringBuilder()
        Dim sr As New StreamReader(XsdFilePath)

        Dim settings As XmlReaderSettings = new XmlReaderSettings()
        Dim reader As XmlReader = XmlReader.Create(sr, settings)
        Dim doc As New XmlDocument()
        doc.Load(reader)

        Dim model As New List(Of Element)
        Dim list As XmlNodeList = doc.ChildNodes()

        Dim schemaNode As XmlNode

        For each node In list
            If node.LocalName = "schema"
                schemaNode = node
                Exit For
            End If
        Next
        Dim masterElementList As List(Of Element) = New List(Of Element)

        model = ReadElements(schemaNode, New Element(), masterElementList)

        ' use the info in that model to write the vb class code. 
        Dim wdns As String = "urn:com.workday/bsvc"
        Dim modelElement As Element
        Dim childElement As Element
        Dim attribute As Attribute

        
        For each modelElement In  masterElementList

            ' make the class
            sb.AppendLine(String.Format("<XmlRoot(ElementName:=""{0}"", Namespace:=""{1}"")>", modelElement.ElementName, wdns))
            sb.AppendLine(String.Format("Public Class {0}", modelElement.ElementName))
            sb.AppendLine(String.Empty)

            ' add the attributes
            For each attribute In modelElement.Attributes
                sb.AppendLine(String.Format("{0}<XmlAttribute(AttributeName:=""{1}"", Namespace:=""{2}"", Form:=XmlSchemaForm.Qualified)>", vbTab, attribute.Name, wdns))
                sb.AppendLine(String.Format("{0}Public Property {1} As {2}", vbTab, attribute.Name, attribute.Type))
                sb.AppendLine(String.Empty)

            Next
            
            ' add the elements
            For each childElement In modelElement.Children

                If childElement.Opt
                    sb.AppendLine(String.Format("{0}'Optional", vbTab))
                End If

                sb.AppendLine(String.Format("{0}<XmlElement(ElementName:=""{1}"", Namespace:=""{2}"")>", vbTab, childElement.ElementName, wdns))


                sb.AppendLine(String.Format("{0}Public Property {1} As {2}", vbTab, childElement.ElementName, childElement.Type))

                sb.AppendLine(String.Empty)

            Next

            ' close the class
            sb.AppendLine("End Class")
            sb.AppendLine(String.Empty)
            sb.AppendLine(String.Empty)


        Next

        Dim fileName As String = VbClassFileDirectory & Date.Now.ToString("yyyy-MM-dd__hh-mm") + "__vb-class.txt"
        File.WriteAllText(fileName, sb.ToString())

    End Sub


    Public Function ReadElements(ByVal Node As XmlNode,  ByVal ParentElement As Element, ByRef MasterElementList As List(Of Element)) As List(Of Element)
        Dim elementList As New List(Of Element)
        ' for each element described
        '    collect the child elements
        '       for each child element, check if they need to be added as their own element, recurse if so
        '    collect the attributes

        For each childNode In Node
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

                If name = "Country_Reference"
                    Dim thing As String = "string"
                End If 

                Dim minOccurs As String = String.Empty
                If childNode.Attributes("minOccurs") IsNot Nothing
                minOccurs = childNode.Attributes("minOccurs").Value
                    If minOccurs = "0"
                        childElement.Opt = false
                    End If
                End If
                    
                Dim maxOccurs As String = String.Empty
                If childNode.Attributes("maxOccurs") IsNot Nothing
                maxOccurs = childNode.Attributes("maxOccurs").Value
                    If maxOccurs = "unbounded"
                        childElement.Multiple = true
                    End If
                End If

                Dim type As String = String.Empty
                If childNode.Attributes("type") IsNot Nothing
                    type = childNode.Attributes("type").Value.Replace("xs:", "")
                    childElement.Type = type
                End If

                childElement.ChildOf = ParentElement.ElementName

                'does this element have children?
                If Node.HasChildNodes
                    If String.IsNullOrWhiteSpace(childElement.Type)
                        childElement.Type = childElement.ElementName
                    End If
                    
                    Dim grandchildNode As XmlNode

                    If childNode.FirstChild IsNot Nothing AndAlso childNode.FirstChild.Name = "xs:complexType"                           
                        If childNode.FirstChild.FirstChild IsNot Nothing
                            If childNode.FirstChild.FirstChild.Name = "xs:sequence"
                                grandchildNode = childNode.FirstChild.FirstChild
                            Else If childNode.FirstChild.FirstChild.Name = "xs:simpleContent"
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
                Dim newAtt As New Attribute()

                If childNode.FirstChild IsNot Nothing AndAlso childNode.FirstChild.Name = "xs:complexType"
                    
                    If childNode.FirstChild.FirstChild IsNot Nothing 
                        If childNode.FirstChild.FirstChild.Name = "xs:sequence"
                            attNodeList = childNode.FirstChild.ChildNodes
                        Else If childNode.FirstChild.FirstChild.Name = "xs:simpleContent"
                            If childNode.FirstChild.FirstChild.FirstChild IsNot Nothing AndAlso childNode.FirstChild.FirstChild.FirstChild.Name = "xs:extension"
                                attNodeList = childNode.FirstChild.FirstChild.FirstChild.ChildNodes
                            End If
                        End If
                        
                    End If
                    
                
                End If


                If attNodeList IsNot Nothing AndAlso attNodeList.Count() > 0

                    For each attNode In attNodeList
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


End Module
