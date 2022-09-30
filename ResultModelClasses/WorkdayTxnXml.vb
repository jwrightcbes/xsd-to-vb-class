Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

' This file covers Workday XML elements that are specific to different transactions 
' with Workday.

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

    <XmlRoot(ElementName:="Get_Applicants_Response", Namespace:="urn:com.workday/bsvc")>
    Public Class Get_Applicants_Response

        <XmlNamespaceDeclarations>
        Public Property xmlns As XmlSerializerNamespaces

        <XmlAttribute(AttributeName:="version", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property version As string

        <XmlElement(ElementName:="Request_References", Namespace:="urn:com.workday/bsvc")>
        Public Property Request_References As Request_References

        <XmlElement(ElementName:="Request_Criteria", Namespace:="urn:com.workday/bsvc")>
        Public Property Request_Criteria As Request_Criteria

        <XmlElement(ElementName:="Response_Filter", Namespace:="urn:com.workday/bsvc")>
        Public Property Response_Filter As Response_Filter

        <XmlElement(ElementName:="Response_Group", Namespace:="urn:com.workday/bsvc")>
        Public Property Response_Group As Response_Group

        <XmlElement(ElementName:="Response_Results", Namespace:="urn:com.workday/bsvc")>
        Public Property Response_Results As Response_Results

        <XmlElement(ElementName:="Response_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Response_Data As Response_Data

        Sub New()
            xmlns = New XmlSerializerNamespaces({
                New XmlQualifiedName("wd", "urn:com.workday/bsvc")
                })
        End Sub

    End Class

    <XmlRoot(ElementName:="Put_Background_Check_Request", Namespace:="urn:com.workday/bsvc")>
	Public Class Put_Background_Check_Request

        <XmlNamespaceDeclarations>
        Public Property xmlns As XmlSerializerNamespaces

		<XmlAttribute(AttributeName:="version", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property version As string

		<XmlElement(ElementName:="Business_Process_Parameters", Namespace:="urn:com.workday/bsvc")>
		Public Property Business_Process_Parameters() As Business_Process_Parameters()

		<XmlElement(ElementName:="Dynamic_Business_Process_Parameters", Namespace:="urn:com.workday/bsvc")>
		Public Property Dynamic_Business_Process_Parameters() As Dynamic_Business_Process_Parameters()

		<XmlElement(ElementName:="Background_Check_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Background_Check_Data() As Background_Check_Data()

        Sub New()
            xmlns = New XmlSerializerNamespaces({
                New XmlQualifiedName("wd", "urn:com.workday/bsvc")
                })
            version = String.Empty

        End Sub


	End Class


End Namespace