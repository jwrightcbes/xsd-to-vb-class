Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
'Imports WorkDay
'Imports WorkDay.WorkdayFunction

Namespace WorkDay
    Public Enum WorkdayRequestType As Integer
    All = 0
    PutApplicantRequest = 1
    PutBackground = 2
    GetApplicantsRequest = 3
    GetApplicantsResponse = 4
    PutBackgroundCheckRequest = 5
End Enum
Public Class WorkdayXmlConstants
    Public Shared ReadOnly WorkdayXmlNamespaces As New XmlSerializerNamespaces({
        New XmlQualifiedName("soapenv", "http://schemas.xmlsoap.org/soap/envelope/"),
        New XmlQualifiedName("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"),
        New XmlQualifiedName("xsd", "http://www.w3.org/2001/XMLSchema")
        })

    Public Shared ReadOnly WorkdayXmlWriterSettings As New System.Xml.XmlWriterSettings With {
            .Encoding = Encoding.UTF8,
            .ConformanceLevel = System.Xml.ConformanceLevel.Document}

End Class

Public Class StringWriterUtf8
    Inherits StringWriter

    Public Overrides ReadOnly Property Encoding() As Encoding
        Get
            Encoding = Encoding.Utf8
        End Get
    End Property

End Class

<XmlRoot(ElementName:="Envelope", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
Public Class WorkdayXmlEnvelope

    <XmlElement(ElementName:="Header", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Property Header As Header

    <XmlElement(ElementName:="Body", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Property Body As Body

    Sub New()
        Header = New Header()
    End Sub

    Sub New(ByVal RequestType As WorkdayRequestType)
        Header = New Header()
        Body = New Body(RequestType)
    End Sub

End Class

    <XmlRoot(ElementName:="Header", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Class Header

        <XmlElement(ElementName:="Workday_Common_Header", Namespace:="urn:com.workday/bsvc")>
        Public Property Workday_Common_Header As Workday_Common_Header

        <XmlElement(ElementName:="Security", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
        Public Property Security As Security

        Sub New()
            Workday_Common_Header = New Workday_Common_Header()
            Security = New Security()
        End Sub

    End Class

    <XmlRoot(ElementName:="Workday_Common_Header", Namespace:="urn:com.workday/bsvc")>
    Public Class Workday_Common_Header

        <XmlNamespaceDeclarations>
        Public Property xmlns As XmlSerializerNamespaces

        <XmlElement(ElementName:="Include_Reference_Descriptors_In_Response", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Reference_Descriptors_In_Response As Boolean

        Sub New()
            xmlns = New XmlSerializerNamespaces({
                New XmlQualifiedName("wd", "urn:com.workday/bsvc")
                })
            Include_Reference_Descriptors_In_Response = True
        End Sub
    End Class

    <XmlRoot(ElementName:="Security", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
    Public Class Security

        <XmlAttribute(AttributeName:="mustUnderstand", Namespace:="http://schemas.xmlsoap.org/soap/envelope/", Form:=XmlSchemaForm.Qualified)>
        Public Property mustUnderstand As String

        <XmlElement(ElementName:="UsernameToken", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
        Public Property UsernameToken As UsernameToken

        Sub New()
            UsernameToken = New UsernameToken()
            mustUnderstand = "1"
        End Sub

    End Class

    <XmlRoot(ElementName:="UsernameToken", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
    Public Class UsernameToken

        <XmlElement(ElementName:="Username", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
        Public Property Username As String

        <XmlElement(ElementName:="Password", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
        Public Property Password As Password

        Sub New()
            Username = String.Empty
            Password = New Password()
        End Sub

    End Class

    <XmlRoot(ElementName:="Password", Namespace:="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")>
    Public Class Password

        <XmlAttribute(AttributeName:="Type")>
        Public Property Type As String

        <XmlText>
        Public Property Text As String

        Sub New()
            Type = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"
            Text = String.Empty
        End Sub

    End Class

    <XmlRoot(ElementName:="Body", Namespace:="http://schemas.xmlsoap.org/soap/envelope/")>
    Public Class Body
        <XmlElement(ElementName:="Get_Applicants_Request", Namespace:="urn:com.workday/bsvc")>
        Public Property Get_Applicants_Request As Get_Applicants_Request

        <XmlElement(ElementName:="Put_Applicant_Request", Namespace:="urn:com.workday/bsvc")>
        Public Property Put_Applicant_Request As Put_Applicant_Request

        <XmlElement(ElementName:="Get_Applicants_Response", Namespace:="urn:com.workday/bsvc")>
        Public Property Get_Applicants_Response As Get_Applicants_Response

        <XmlElement(ElementName:="Put_Background_Check_Request", Namespace:="urn:com.workday/bsvc")>
        Public Property Put_Background_Check_Request As Put_Background_Check_Request

        Sub New()
        End Sub

        Sub New(ByVal RequestType As WorkdayRequestType)

            Select RequestType
                Case WorkdayRequestType.GetApplicantsRequest
                    Get_Applicants_Request = New Get_Applicants_Request()
                Case WorkdayRequestType.PutApplicantRequest
                    Put_Applicant_Request = New Put_Applicant_Request()
                Case WorkdayRequestType.GetApplicantsResponse
                    Get_Applicants_Response = New Get_Applicants_Response()
                Case WorkdayRequestType.PutBackgroundCheckRequest
                    Put_Background_Check_Request = New Put_Background_Check_Request()
            End Select

        End Sub

    End Class

End Namespace