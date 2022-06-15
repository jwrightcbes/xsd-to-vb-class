Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

' This file covers Workday XML elements that are specific to the different transactions 
' that deal with the Applicant object.

Namespace WorkDay        

    <XmlRoot(ElementName:="Put_Applicant_Request", Namespace:="urn:com.workday/bsvc")>
    Public Class Put_Applicant_Request

        <XmlNamespaceDeclarations>
        Public Property xmlns As XmlSerializerNamespaces

        <XmlAttribute(AttributeName:="version", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property version As String

        <XmlElement(ElementName:="Applicant_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Reference As Applicant_Reference

        <XmlElement(ElementName:="Applicant_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Data As Applicant_Data

        Sub New()
            xmlns = New XmlSerializerNamespaces({
                New XmlQualifiedName("wd", "urn:com.workday/bsvc")
                })
            version = String.Empty
            Applicant_Reference = New Applicant_Reference()
            Applicant_Data = New Applicant_Data()

        End Sub

    End Class

    <XmlRoot(ElementName:="Get_Applicants_Request", Namespace:="urn:com.workday/bsvc")>
    Public Class Get_Applicants_Request

        <XmlNamespaceDeclarations>
        Public Property xmlns As XmlSerializerNamespaces

        <XmlAttribute(AttributeName:="version", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property version As String

        <XmlElement(ElementName:="Request_References", Namespace:="urn:com.workday/bsvc")>
        Public Property Request_References As Request_References

        Sub New()
            xmlns = New XmlSerializerNamespaces({
                New XmlQualifiedName("wd", "urn:com.workday/bsvc")
                })
            version = String.Empty
            Request_References = New Request_References()
        End Sub
    End Class


End Namespace