Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

' This file covers Workday XML elements related to Applicant objects.
' These are used in multiple different transactions dealing with Applicants.

Namespace WorkDay
    <XmlRoot(ElementName:="Applicant_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Applicant_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
    Public Class ID

        <XmlAttribute(AttributeName:="type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property type As String

        <XmlAttribute(AttributeName:="parent_id", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property parent_id As String

        <XmlAttribute(AttributeName:="parent_type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property parent_type As String

        <XmlAttribute(AttributeName:="System_ID", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property System_ID As String

        <XmlText>
        Public Property ID_Text As String

    End Class


    <XmlRoot(ElementName:="Title_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Title_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Salutation_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Salutation_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Prefix_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Prefix_Data

        <XmlElement(ElementName:="Title_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Title_Descriptor As String

        <XmlElement(ElementName:="Title_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Title_Reference() As Title_Reference()

        <XmlElement(ElementName:="Salutation_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Salutation_Reference() As Salutation_Reference()

    End Class


    <XmlRoot(ElementName:="Local_Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Local_Name_Detail_Data

        <XmlAttribute(AttributeName:="Local_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Local_Name As String

        <XmlAttribute(AttributeName:="Local_Script", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Local_Script As String

        <XmlElement(ElementName:="First_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property First_Name As String

        <XmlElement(ElementName:="Middle_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Middle_Name As String

        <XmlElement(ElementName:="Last_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Name As String

        <XmlElement(ElementName:="Secondary_Last_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Secondary_Last_Name As String

        <XmlElement(ElementName:="First_Name_2", Namespace:="urn:com.workday/bsvc")>
        Public Property First_Name_2 As String

        <XmlElement(ElementName:="Middle_Name_2", Namespace:="urn:com.workday/bsvc")>
        Public Property Middle_Name_2 As String

        <XmlElement(ElementName:="Last_Name_2", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Name_2 As String

        <XmlElement(ElementName:="Secondary_Last_Name_2", Namespace:="urn:com.workday/bsvc")>
        Public Property Secondary_Last_Name_2 As String

    End Class


    <XmlRoot(ElementName:="Social_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Social_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Academic_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Academic_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Hereditary_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Hereditary_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Honorary_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Honorary_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Professional_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Professional_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Religious_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Religious_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Royal_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Royal_Suffix_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Suffix_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Suffix_Data

        <XmlElement(ElementName:="Social_Suffix_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Social_Suffix_Descriptor As String

        <XmlElement(ElementName:="Social_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Social_Suffix_Reference() As Social_Suffix_Reference()

        <XmlElement(ElementName:="Academic_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Academic_Suffix_Reference() As Academic_Suffix_Reference()

        <XmlElement(ElementName:="Hereditary_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Hereditary_Suffix_Reference() As Hereditary_Suffix_Reference()

        <XmlElement(ElementName:="Honorary_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Honorary_Suffix_Reference() As Honorary_Suffix_Reference()

        <XmlElement(ElementName:="Professional_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Suffix_Reference() As Professional_Suffix_Reference()

        <XmlElement(ElementName:="Religious_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Religious_Suffix_Reference() As Religious_Suffix_Reference()

        <XmlElement(ElementName:="Royal_Suffix_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Royal_Suffix_Reference() As Royal_Suffix_Reference()

    End Class


    <XmlRoot(ElementName:="Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Name_Detail_Data

        <XmlAttribute(AttributeName:="Formatted_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Formatted_Name As String

        <XmlAttribute(AttributeName:="Reporting_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Reporting_Name As String

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="First_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property First_Name As String

        <XmlElement(ElementName:="Middle_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Middle_Name As String

        <XmlElement(ElementName:="Last_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Name As String

        <XmlElement(ElementName:="Secondary_Last_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Secondary_Last_Name As String

        <XmlElement(ElementName:="Tertiary_Last_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Tertiary_Last_Name As String

        <XmlElement(ElementName:="Full_Name_for_Singapore_and_Malaysia", Namespace:="urn:com.workday/bsvc")>
        Public Property Full_Name_for_Singapore_and_Malaysia As String

        <XmlElement(ElementName:="Prefix_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Prefix_Data() As Prefix_Data()

        <XmlElement(ElementName:="Local_Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Local_Name_Detail_Data() As Local_Name_Detail_Data()

        <XmlElement(ElementName:="Suffix_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Suffix_Data() As Suffix_Data()

    End Class


    <XmlRoot(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Country_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Status_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class ID_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Verified_By_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Verified_By_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Country_Region_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Country_Region_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Address_Line_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Address_Line_Data

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlAttribute(AttributeName:="Type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Type As String

        <XmlText>
        Public Property Address_Line_Data_Text As String

    End Class


    <XmlRoot(ElementName:="Country_City_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Country_City_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Submunicipality_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Submunicipality_Data

        <XmlAttribute(AttributeName:="Address_Component_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Address_Component_Name As String

        <XmlAttribute(AttributeName:="Type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Type As String

        <XmlText>
        Public Property Submunicipality_Data_Text As String

    End Class


    <XmlRoot(ElementName:="Subregion_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Subregion_Data

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlAttribute(AttributeName:="Type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Type As String

        <XmlText>
        Public Property Subregion_Data_Text As String

    End Class


    <XmlRoot(ElementName:="Address_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Address_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Address_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Address_Data

        <XmlAttribute(AttributeName:="Address_Format_Type", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Address_Format_Type As String

        <XmlAttribute(AttributeName:="Defaulted_Business_Site_Address", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Defaulted_Business_Site_Address As String

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlAttribute(AttributeName:="Do_Not_Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Do_Not_Replace_All As String

        <XmlAttribute(AttributeName:="Effective_Date", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Effective_Date As String

        <XmlAttribute(AttributeName:="Formatted_Address", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Formatted_Address As String

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Last_Modified", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Modified As String

        <XmlElement(ElementName:="Address_Line_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Address_Line_Data() As Address_Line_Data()

        <XmlElement(ElementName:="Municipality", Namespace:="urn:com.workday/bsvc")>
        Public Property Municipality As String

        <XmlElement(ElementName:="Country_Region_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Region_Descriptor As String

        <XmlElement(ElementName:="Postal_Code", Namespace:="urn:com.workday/bsvc")>
        Public Property Postal_Code As String

        <XmlElement(ElementName:="Number_of_Days", Namespace:="urn:com.workday/bsvc")>
        Public Property Number_of_Days As String

        <XmlElement(ElementName:="Municipality_Local", Namespace:="urn:com.workday/bsvc")>
        Public Property Municipality_Local As String               

        <XmlElement(ElementName:="Country_City_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_City_Reference() As Country_City_Reference()

        <XmlElement(ElementName:="Submunicipality_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Submunicipality_Data() As Submunicipality_Data()

        <XmlElement(ElementName:="Country_Region_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Region_Reference() As Country_Region_Reference()

        <XmlElement(ElementName:="Subregion_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Subregion_Data() As Subregion_Data()

        <XmlElement(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Usage_Data() As Usage_Data()

        <XmlElement(ElementName:="Address_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Address_Reference() As Address_Reference()

        <XmlElement(ElementName:="Address_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Address_ID As String 

    End Class


    <XmlRoot(ElementName:="Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Type_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Type_Data

        <XmlAttribute(AttributeName:="Primary", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Primary As String

        <XmlElement(ElementName:="Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Type_Reference() As Type_Reference()

    End Class


    <XmlRoot(ElementName:="Use_For_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Use_For_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Use_For_Tenanted_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Use_For_Tenanted_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Usage_Data

        <XmlAttribute(AttributeName:="Public", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property _Public As String

        <XmlElement(ElementName:="Comments", Namespace:="urn:com.workday/bsvc")>
        Public Property Comments As String

        <XmlElement(ElementName:="Type_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Type_Data() As Type_Data()

        <XmlElement(ElementName:="Use_For_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Use_For_Reference() As Use_For_Reference()

        <XmlElement(ElementName:="Use_For_Tenanted_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Use_For_Tenanted_Reference() As Use_For_Tenanted_Reference()

    End Class


    <XmlRoot(ElementName:="Phone_Device_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Phone_Device_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Phone_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Phone_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Phone_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Phone_Data

        <XmlAttribute(AttributeName:="Area_Code", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property attArea_Code As String

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlAttribute(AttributeName:="Do_Not_Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Do_Not_Replace_All As String

        <XmlAttribute(AttributeName:="Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Formatted_Phone As String

        <XmlAttribute(AttributeName:="E164_Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property E164_Formatted_Phone As String

        <XmlAttribute(AttributeName:="International_Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property International_Formatted_Phone As String

        <XmlAttribute(AttributeName:="National_Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property National_Formatted_Phone As String

        <XmlAttribute(AttributeName:="Phone_Number_Without_Area_Code", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Phone_Number_Without_Area_Code As String

        <XmlAttribute(AttributeName:="Tenant_Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Tenant_Formatted_Phone As String

        <XmlAttribute(AttributeName:="Workday_Traditional_Formatted_Phone", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Workday_Traditional_Formatted_Phone As String

        <XmlElement(ElementName:="Country_ISO_Code", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_ISO_Code As String

        <XmlElement(ElementName:="International_Phone_Code", Namespace:="urn:com.workday/bsvc")>
        Public Property International_Phone_Code As String

        <XmlElement(ElementName:="Area_Code", Namespace:="urn:com.workday/bsvc")>
        Public Property Area_Code As String

        <XmlElement(ElementName:="Phone_Number", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Number As String

        <XmlElement(ElementName:="Phone_Extension", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Extension As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Phone_Device_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Device_Type_Reference() As Phone_Device_Type_Reference()

        <XmlElement(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Usage_Data() As Usage_Data()

        <XmlElement(ElementName:="Phone_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Reference() As Phone_Reference()

    End Class


    <XmlRoot(ElementName:="Email_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Email_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Email_Address_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Email_Address_Data

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlAttribute(AttributeName:="Do_Not_Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Do_Not_Replace_All As String

        <XmlElement(ElementName:="Email_Address", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Address As String

        <XmlElement(ElementName:="Email_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Comment As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Usage_Data() As Usage_Data()

        <XmlElement(ElementName:="Email_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Reference() As Email_Reference()

    End Class


    <XmlRoot(ElementName:="Instant_Messenger_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Instant_Messenger_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Instant_Messenger_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Instant_Messenger_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Instant_Messenger_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Instant_Messenger_Data

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlAttribute(AttributeName:="Do_Not_Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Do_Not_Replace_All As String

        <XmlElement(ElementName:="Instant_Messenger_Address", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Address As String

        <XmlElement(ElementName:="Instant_Messenger_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Comment As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Instant_Messenger_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Type_Reference() As Instant_Messenger_Type_Reference()

        <XmlElement(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Usage_Data() As Usage_Data()

        <XmlElement(ElementName:="Instant_Messenger_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Reference() As Instant_Messenger_Reference()

    End Class


    <XmlRoot(ElementName:="Web_Address_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Web_Address_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Web_Address_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Web_Address_Data

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlAttribute(AttributeName:="Do_Not_Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Do_Not_Replace_All As String

        <XmlElement(ElementName:="Web_Address", Namespace:="urn:com.workday/bsvc")>
        Public Property Web_Address As String

        <XmlElement(ElementName:="Web_Address_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Web_Address_Comment As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Usage_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Usage_Data() As Usage_Data()

        <XmlElement(ElementName:="Web_Address_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Web_Address_Reference() As Web_Address_Reference()

    End Class


    <XmlRoot(ElementName:="Certification_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Certification_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Document_Category_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Document_Category_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Request_References", Namespace:="urn:com.workday/bsvc")>
    Public Class Request_References

        <XmlElement(ElementName:="Applicant_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Reference() As Applicant_Reference()

    End Class


    <XmlRoot(ElementName:="Worker_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Worker_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Former_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Former_Worker_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Provider_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Provider_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Field_And_Parameter_Criteria_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Field_And_Parameter_Criteria_Data

        <XmlElement(ElementName:="Provider_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Provider_Reference() As Provider_Reference()

    End Class


    <XmlRoot(ElementName:="Request_Criteria", Namespace:="urn:com.workday/bsvc")>
    Public Class Request_Criteria

        <XmlElement(ElementName:="Email_Address", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Address As String

        <XmlElement(ElementName:="Worker_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Worker_Reference() As Worker_Reference()

        <XmlElement(ElementName:="Former_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Former_Worker_Reference() As Former_Worker_Reference()

        <XmlElement(ElementName:="Field_And_Parameter_Criteria_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Field_And_Parameter_Criteria_Data() As Field_And_Parameter_Criteria_Data()

    End Class


    <XmlRoot(ElementName:="Response_Filter", Namespace:="urn:com.workday/bsvc")>
    Public Class Response_Filter

        <XmlElement(ElementName:="As_Of_Effective_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property As_Of_Effective_Date As String

        <XmlElement(ElementName:="As_Of_Entry_DateTime", Namespace:="urn:com.workday/bsvc")>
        Public Property As_Of_Entry_DateTime As String

        <XmlElement(ElementName:="Page", Namespace:="urn:com.workday/bsvc")>
        Public Property Page As String

        <XmlElement(ElementName:="Count", Namespace:="urn:com.workday/bsvc")>
        Public Property Count As String

    End Class


    <XmlRoot(ElementName:="Response_Group", Namespace:="urn:com.workday/bsvc")>
    Public Class Response_Group

        <XmlElement(ElementName:="Include_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Reference As String

        <XmlElement(ElementName:="Include_Personal_Information", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Personal_Information As String

        <XmlElement(ElementName:="Include_Recruiting_Information", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Recruiting_Information As String

        <XmlElement(ElementName:="Include_Qualification_Profile", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Qualification_Profile As String

        <XmlElement(ElementName:="Include_Resume", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Resume As String

        <XmlElement(ElementName:="Include_Background_Check", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_Background_Check As String

        <XmlElement(ElementName:="Include_External_Integration_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Include_External_Integration_ID_Data As String

    End Class


    <XmlRoot(ElementName:="Response_Results", Namespace:="urn:com.workday/bsvc")>
    Public Class Response_Results

        <XmlElement(ElementName:="Total_Results", Namespace:="urn:com.workday/bsvc")>
        Public Property Total_Results As String

        <XmlElement(ElementName:="Total_Pages", Namespace:="urn:com.workday/bsvc")>
        Public Property Total_Pages As String

        <XmlElement(ElementName:="Page_Results", Namespace:="urn:com.workday/bsvc")>
        Public Property Page_Results As String

        <XmlElement(ElementName:="Page", Namespace:="urn:com.workday/bsvc")>
        Public Property Page As String

    End Class


    <XmlRoot(ElementName:="Legal_Name_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Legal_Name_Data

        <XmlElement(ElementName:="Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Detail_Data() As Name_Detail_Data()

    End Class


    <XmlRoot(ElementName:="Preferred_Name_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Preferred_Name_Data

        <XmlElement(ElementName:="Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Detail_Data() As Name_Detail_Data()

    End Class


    <XmlRoot(ElementName:="Name_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Name_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Additional_Name_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Additional_Name_Data

        <XmlElement(ElementName:="Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Detail_Data() As Name_Detail_Data()

        <XmlElement(ElementName:="Name_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Type_Reference() As Name_Type_Reference()

    End Class


    <XmlRoot(ElementName:="Name_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Name_Data

        <XmlElement(ElementName:="Legal_Name_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Legal_Name_Data() As Legal_Name_Data()

        <XmlElement(ElementName:="Preferred_Name_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Preferred_Name_Data() As Preferred_Name_Data()

        <XmlElement(ElementName:="Additional_Name_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Additional_Name_Data() As Additional_Name_Data()

    End Class


    <XmlRoot(ElementName:="Gender_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Gender_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Country_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Country_of_Birth_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Region_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Region_of_Birth_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="City_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class City_of_Birth_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Marital_Status_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Marital_Status_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Religion_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Religion_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Grade_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Grade_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Certification_Authority_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Certification_Authority_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Certification_Basis_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Certification_Basis_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Worker_Document_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Worker_Document_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Status_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Status_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Disability_Status_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Disability_Status_Data

        <XmlElement(ElementName:="Disability_Status_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Status_Date As String

        <XmlElement(ElementName:="Disability_Date_Known", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Date_Known As String

        <XmlElement(ElementName:="Disability_End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_End_Date As String

        <XmlElement(ElementName:="Disability_Degree", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Degree As String

        <XmlElement(ElementName:="Disability_Remaining_Capacity", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Remaining_Capacity As String

        <XmlElement(ElementName:="Disability_Certification_Authority", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Certification_Authority As String

        <XmlElement(ElementName:="Disability_Certified_At", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Certified_At As String

        <XmlElement(ElementName:="Disability_Certification_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Certification_ID As String

        <XmlElement(ElementName:="Disability_Severity_Recognition_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Severity_Recognition_Date As String

        <XmlElement(ElementName:="Disability_FTE_Toward_Quota", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_FTE_Toward_Quota As String

        <XmlElement(ElementName:="Disability_Work_Restrictions", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Work_Restrictions As String

        <XmlElement(ElementName:="Disability_Accommodations_Requested", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Accommodations_Requested As String

        <XmlElement(ElementName:="Disability_Accommodations_Provided", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Accommodations_Provided As String

        <XmlElement(ElementName:="Disability_Rehabilitation_Requested", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Rehabilitation_Requested As String

        <XmlElement(ElementName:="Disability_Rehabilitation_Provided", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Rehabilitation_Provided As String

        <XmlElement(ElementName:="Note", Namespace:="urn:com.workday/bsvc")>
        Public Property Note As String

        <XmlElement(ElementName:="Disability_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Reference() As Disability_Reference()

        <XmlElement(ElementName:="Disability_Grade_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Grade_Reference() As Disability_Grade_Reference()

        <XmlElement(ElementName:="Disability_Certification_Authority_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Certification_Authority_Reference() As Disability_Certification_Authority_Reference()

        <XmlElement(ElementName:="Disability_Certification_Basis_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Certification_Basis_Reference() As Disability_Certification_Basis_Reference()

        <XmlElement(ElementName:="Worker_Document_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Worker_Document_Reference() As Worker_Document_Reference()

        <XmlElement(ElementName:="Disability_Status_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Status_Reference() As Disability_Status_Reference()

    End Class


    <XmlRoot(ElementName:="Ethnicity_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Ethnicity_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Citizenship_Status_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Citizenship_Status_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Primary_Nationality_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Primary_Nationality_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Additional_Nationality_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Additional_Nationality_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Hukou_Region_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Hukou_Region_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Hukou_Subregion_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Hukou_Subregion_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Hukou_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Hukou_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Native_Region_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Native_Region_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Blood_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Blood_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Military_Service_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Military_Service_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Military_Rank_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Military_Rank_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Military_Service_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Military_Service_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Military_Service_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Military_Service_Data

        <XmlElement(ElementName:="Discharge_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Discharge_Date As String

        <XmlElement(ElementName:="Status_Begin_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Status_Begin_Date As String

        <XmlElement(ElementName:="Notes", Namespace:="urn:com.workday/bsvc")>
        Public Property Notes As String

        <XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Status_Reference() As Status_Reference()

        <XmlElement(ElementName:="Military_Service_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Military_Service_Type_Reference() As Military_Service_Type_Reference()

        <XmlElement(ElementName:="Military_Rank_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Military_Rank_Reference() As Military_Rank_Reference()

        <XmlElement(ElementName:="Military_Service_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Military_Service_Reference() As Military_Service_Reference()

    End Class


    <XmlRoot(ElementName:="National_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class National_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="National_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class National_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Series", Namespace:="urn:com.workday/bsvc")>
        Public Property Series As String

        <XmlElement(ElementName:="Issuing_Agency", Namespace:="urn:com.workday/bsvc")>
        Public Property Issuing_Agency As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Verification_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Verification_Date As String

        <XmlElement(ElementName:="Verified_By_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Verified_By_Reference() As Verified_By_Reference()

    End Class


    <XmlRoot(ElementName:="National_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class National_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="National_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class National_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="National_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property National_ID_Reference() As National_ID_Reference()

        <XmlElement(ElementName:="National_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property National_ID_Data() As National_ID_Data()

        <XmlElement(ElementName:="National_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property National_ID_Shared_Reference() As National_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="Government_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Government_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Government_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Government_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Verification_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Verification_Date As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Verified_by_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Verified_by_Reference() As Verified_By_Reference()

    End Class


    <XmlRoot(ElementName:="Government_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Government_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Government_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class Government_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="Government_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Government_ID_Reference() As Government_ID_Reference()

        <XmlElement(ElementName:="Government_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Government_ID_Data() As Government_ID_Data()

        <XmlElement(ElementName:="Government_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Government_ID_Shared_Reference() As Government_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="Visa_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Visa_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Visa_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Visa_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Verification_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Verification_Date As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Verified_By_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Verified_By_Reference() As Verified_By_Reference()

    End Class


    <XmlRoot(ElementName:="Visa_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Visa_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Visa_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class Visa_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="Visa_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Visa_ID_Reference() As Visa_ID_Reference()

        <XmlElement(ElementName:="Visa_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Visa_ID_Data() As Visa_ID_Data()

        <XmlElement(ElementName:="Visa_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Visa_ID_Shared_Reference() As Visa_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="Passport_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Passport_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Passport_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Passport_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Verification_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Verification_Date As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Verified_By_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Verified_By_Reference() As Verified_By_Reference()

    End Class


    <XmlRoot(ElementName:="Passport_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Passport_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Passport_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class Passport_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="Passport_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Passport_ID_Reference() As Passport_ID_Reference()

        <XmlElement(ElementName:="Passport_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Passport_ID_Data() As Passport_ID_Data()

        <XmlElement(ElementName:="Passport_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Passport_ID_Shared_Reference() As Passport_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="License_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class License_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Authority_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Authority_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="License_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class License_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Country_Region_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Region_Descriptor As String

        <XmlElement(ElementName:="License_Class", Namespace:="urn:com.workday/bsvc")>
        Public Property License_Class As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Verification_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Verification_Date As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Country_Region_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Region_Reference() As Country_Region_Reference()

        <XmlElement(ElementName:="Authority_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Authority_Reference() As Authority_Reference()

        <XmlElement(ElementName:="Verified_By_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Verified_By_Reference() As Verified_By_Reference()

    End Class


    <XmlRoot(ElementName:="License_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class License_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="License_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class License_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="License_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property License_ID_Reference() As License_ID_Reference()

        <XmlElement(ElementName:="License_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property License_ID_Data() As License_ID_Data()

        <XmlElement(ElementName:="License_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property License_ID_Shared_Reference() As License_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="Custom_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Custom_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Organization_ID_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Organization_ID_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Custom_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Custom_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Custom_Description", Namespace:="urn:com.workday/bsvc")>
        Public Property Custom_Description As String

        <XmlElement(ElementName:="ID_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property ID_Type_Reference() As ID_Type_Reference()

        <XmlElement(ElementName:="Organization_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Organization_ID_Reference() As Organization_ID_Reference()

    End Class


    <XmlRoot(ElementName:="Custom_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Custom_ID_Shared_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Custom_ID", Namespace:="urn:com.workday/bsvc")>
    Public Class Custom_ID

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="Custom_ID_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Custom_ID_Reference() As Custom_ID_Reference()

        <XmlElement(ElementName:="Custom_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Custom_ID_Data() As Custom_ID_Data()

        <XmlElement(ElementName:="Custom_ID_Shared_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Custom_ID_Shared_Reference() As Custom_ID_Shared_Reference()

    End Class


    <XmlRoot(ElementName:="Identification_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Identification_Data

        <XmlElement(ElementName:="National_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property National_ID() As National_ID()

        <XmlElement(ElementName:="Government_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Government_ID() As Government_ID()

        <XmlElement(ElementName:="Visa_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Visa_ID() As Visa_ID()

        <XmlElement(ElementName:="Passport_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Passport_ID() As Passport_ID()

        <XmlElement(ElementName:="License_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property License_ID() As License_ID()

        <XmlElement(ElementName:="Custom_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Custom_ID() As Custom_ID()

    End Class


    <XmlRoot(ElementName:="Contact_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Contact_Data

        <XmlElement(ElementName:="Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Address_Data() As Address_Data()

        <XmlElement(ElementName:="Phone_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Data() As Phone_Data()

        <XmlElement(ElementName:="Email_Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Address_Data() As Email_Address_Data()

        <XmlElement(ElementName:="Instant_Messenger_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Data() As Instant_Messenger_Data()

        <XmlElement(ElementName:="Web_Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Web_Address_Data() As Web_Address_Data()

    End Class


    <XmlRoot(ElementName:="Political_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Political_Affiliation_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Social_Benefits_Locality_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Social_Benefits_Locality_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Relative_Name_Reference_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Relative_Name_Reference_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Relative_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Relative_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Relative_Name_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Relative_Name_Data

        <XmlAttribute(AttributeName:="Delete", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Delete As String

        <XmlElement(ElementName:="Relative_Name_Reference_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Relative_Name_Reference_Reference() As Relative_Name_Reference_Reference()

        <XmlElement(ElementName:="Relative_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Relative_Type_Reference() As Relative_Type_Reference()

        <XmlElement(ElementName:="Name_Detail_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Detail_Data() As Name_Detail_Data()

    End Class


    <XmlRoot(ElementName:="Relative_Name_Information_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Relative_Name_Information_Data

        <XmlAttribute(AttributeName:="Replace_All", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Replace_All As String

        <XmlElement(ElementName:="Relative_Name_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Relative_Name_Data() As Relative_Name_Data()

    End Class


    <XmlRoot(ElementName:="Personal_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Personal_Data

        <XmlElement(ElementName:="Universal_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Universal_ID As String

        <XmlElement(ElementName:="Date_of_Death", Namespace:="urn:com.workday/bsvc")>
        Public Property Date_of_Death As String

        <XmlElement(ElementName:="Region_of_Birth_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Region_of_Birth_Descriptor As String

        <XmlElement(ElementName:="City_of_Birth", Namespace:="urn:com.workday/bsvc")>
        Public Property City_of_Birth As String

        <XmlElement(ElementName:="Marital_Status_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Marital_Status_Date As String

        <XmlElement(ElementName:="Hispanic_or_Latino", Namespace:="urn:com.workday/bsvc")>
        Public Property Hispanic_or_Latino As String

        <XmlElement(ElementName:="Hukou_Locality", Namespace:="urn:com.workday/bsvc")>
        Public Property Hukou_Locality As String

        <XmlElement(ElementName:="Hukou_Postal_Code", Namespace:="urn:com.workday/bsvc")>
        Public Property Hukou_Postal_Code As String

        <XmlElement(ElementName:="Local_Hukou", Namespace:="urn:com.workday/bsvc")>
        Public Property Local_Hukou As String

        <XmlElement(ElementName:="Native_Region_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Native_Region_Descriptor As String

        <XmlElement(ElementName:="Personnel_File_Agency_for_Person", Namespace:="urn:com.workday/bsvc")>
        Public Property Personnel_File_Agency_for_Person As String

        <XmlElement(ElementName:="Last_Medical_Exam_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Medical_Exam_Date As String

        <XmlElement(ElementName:="Last_Medical_Exam_Valid_To", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Medical_Exam_Valid_To As String

        <XmlElement(ElementName:="Medical_Exam_Notes", Namespace:="urn:com.workday/bsvc")>
        Public Property Medical_Exam_Notes As String

        <XmlElement(ElementName:="Name_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Name_Data() As Name_Data()

        <XmlElement(ElementName:="Birth_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Birth_Date As String

        <XmlElement(ElementName:="Gender_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Gender_Reference() As Gender_Reference()

        <XmlElement(ElementName:="Country_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_of_Birth_Reference() As Country_of_Birth_Reference()

        <XmlElement(ElementName:="Region_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Region_of_Birth_Reference() As Region_of_Birth_Reference()

        <XmlElement(ElementName:="City_of_Birth_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property City_of_Birth_Reference() As City_of_Birth_Reference()

        <XmlElement(ElementName:="Marital_Status_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Marital_Status_Reference() As Marital_Status_Reference()

        <XmlElement(ElementName:="Religion_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Religion_Reference() As Religion_Reference()

        <XmlElement(ElementName:="Disability_Status_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Disability_Status_Data() As Disability_Status_Data()

        <XmlElement(ElementName:="Ethnicity_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Ethnicity_Reference() As Ethnicity_Reference()

        <XmlElement(ElementName:="Citizenship_Status_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Citizenship_Status_Reference() As Citizenship_Status_Reference()

        <XmlElement(ElementName:="Primary_Nationality_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Primary_Nationality_Reference() As Primary_Nationality_Reference()

        <XmlElement(ElementName:="Additional_Nationality_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Additional_Nationality_Reference() As Additional_Nationality_Reference()

        <XmlElement(ElementName:="Hukou_Region_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Hukou_Region_Reference() As Hukou_Region_Reference()

        <XmlElement(ElementName:="Hukou_Subregion_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Hukou_Subregion_Reference() As Hukou_Subregion_Reference()

        <XmlElement(ElementName:="Hukou_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Hukou_Type_Reference() As Hukou_Type_Reference()

        <XmlElement(ElementName:="Native_Region_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Native_Region_Reference() As Native_Region_Reference()

        <XmlElement(ElementName:="Blood_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Blood_Type_Reference() As Blood_Type_Reference()

        <XmlElement(ElementName:="Military_Service_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Military_Service_Data() As Military_Service_Data()

        <XmlElement(ElementName:="Identification_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Identification_Data() As Identification_Data()

        <XmlElement(ElementName:="Contact_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Contact_Data() As Contact_Data()

        <XmlElement(ElementName:="Political_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Political_Affiliation_Reference() As Political_Affiliation_Reference()

        <XmlElement(ElementName:="Social_Benefits_Locality_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Social_Benefits_Locality_Reference() As Social_Benefits_Locality_Reference()

        <XmlElement(ElementName:="Relative_Name_Information_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Relative_Name_Information_Data() As Relative_Name_Information_Data()

        <XmlElement(ElementName:="Tobacco_Use", Namespace:="urn:com.workday/bsvc")>
        Public Property Tobacco_Use As String

    End Class


    <XmlRoot(ElementName:="Job_History_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Job_History_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Job_History_Company_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Job_History_Company_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Job_History_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Job_History_Data

        <XmlElement(ElementName:="Job_History_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_History_ID As String

        <XmlElement(ElementName:="Remove_Job_History", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Job_History As String

        <XmlElement(ElementName:="Job_Title", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_Title As String

        <XmlElement(ElementName:="Company", Namespace:="urn:com.workday/bsvc")>
        Public Property Company As String

        <XmlElement(ElementName:="Start_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Start_Date As String

        <XmlElement(ElementName:="End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property End_Date As String

        <XmlElement(ElementName:="Responsibilities_and_Achievements", Namespace:="urn:com.workday/bsvc")>
        Public Property Responsibilities_and_Achievements As String

        <XmlElement(ElementName:="Location", Namespace:="urn:com.workday/bsvc")>
        Public Property Location As String

        <XmlElement(ElementName:="Job_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_Reference As String

        <XmlElement(ElementName:="Contact", Namespace:="urn:com.workday/bsvc")>
        Public Property Contact As String

        <XmlElement(ElementName:="Job_History_Company_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_History_Company_Reference() As Job_History_Company_Reference()

    End Class


    <XmlRoot(ElementName:="External_Job_History", Namespace:="urn:com.workday/bsvc")>
    Public Class External_Job_History

        <XmlElement(ElementName:="Job_History_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_History_Reference() As Job_History_Reference()

        <XmlElement(ElementName:="Job_History_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Job_History_Data() As Job_History_Data()

    End Class


    <XmlRoot(ElementName:="Competency_Level_Behavior_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Competency_Level_Behavior_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Assessed_By_Person_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Assessed_By_Person_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Competency_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Competency_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Competency", Namespace:="urn:com.workday/bsvc")>
    Public Class Competency

        <XmlElement(ElementName:="Competency_Level_Behavior_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Competency_Level_Behavior_Descriptor As String

        <XmlElement(ElementName:="Assessment_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessment_Comment As String

        <XmlElement(ElementName:="Assessed_On", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessed_On As String

        <XmlElement(ElementName:="Assessed_By_Worker_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessed_By_Worker_Descriptor As String

        <XmlElement(ElementName:="Competency_Descriptor", Namespace:="urn:com.workday/bsvc")>
        Public Property Competency_Descriptor As String

        <XmlElement(ElementName:="Competency_Level_Behavior_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Competency_Level_Behavior_Reference() As Competency_Level_Behavior_Reference()

        <XmlElement(ElementName:="Assessed_By_Person_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessed_By_Person_Reference() As Assessed_By_Person_Reference()

        <XmlElement(ElementName:="Competency_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Competency_Reference() As Competency_Reference()

    End Class


    <XmlRoot(ElementName:="Specialty_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Specialty_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Subspecialty_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Subspecialty_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Specialty_Achievement_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Specialty_Achievement_Data

        <XmlElement(ElementName:="Start_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Start_Date As String

        <XmlElement(ElementName:="End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property End_Date As String

        <XmlElement(ElementName:="Specialty_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Specialty_Reference() As Specialty_Reference()

        <XmlElement(ElementName:="Subspecialty_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Subspecialty_Reference() As Subspecialty_Reference()

    End Class


    <XmlRoot(ElementName:="Worker_Document_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Worker_Document_Data

        <XmlElement(ElementName:="File_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property File_Name As String

        <XmlElement(ElementName:="Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Comment As String

        <XmlElement(ElementName:="File", Namespace:="urn:com.workday/bsvc")>
        Public Property File As String

        <XmlElement(ElementName:="Content_Type", Namespace:="urn:com.workday/bsvc")>
        Public Property Content_Type As String

        <XmlElement(ElementName:="Document_Category_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Document_Category_Reference() As Document_Category_Reference()

    End Class


    <XmlRoot(ElementName:="Certification_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Certification_Data

        <XmlElement(ElementName:="Certification_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_ID As String

        <XmlElement(ElementName:="Remove_Certification", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Certification As String

        <XmlElement(ElementName:="Certification_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_Name As String

        <XmlElement(ElementName:="Issuer", Namespace:="urn:com.workday/bsvc")>
        Public Property Issuer As String

        <XmlElement(ElementName:="Certification_Number", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_Number As String

        <XmlElement(ElementName:="Issued_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Issued_Date As String

        <XmlElement(ElementName:="Expiration_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Expiration_Date As String

        <XmlElement(ElementName:="Examination_Score", Namespace:="urn:com.workday/bsvc")>
        Public Property Examination_Score As String

        <XmlElement(ElementName:="Examination_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Examination_Date As String

        <XmlElement(ElementName:="Certification_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_Reference() As Certification_Reference()

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="Specialty_Achievement_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Specialty_Achievement_Data() As Specialty_Achievement_Data()

        <XmlElement(ElementName:="Worker_Document_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Worker_Document_Data() As Worker_Document_Data()

    End Class


    <XmlRoot(ElementName:="Certification", Namespace:="urn:com.workday/bsvc")>
    Public Class Certification

        <XmlElement(ElementName:="Certification_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_Reference() As Certification_Reference()

        <XmlElement(ElementName:="Certification_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification_Data() As Certification_Data()

    End Class


    <XmlRoot(ElementName:="Training_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Training_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Training_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Training_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Training_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Training_Data

        <XmlElement(ElementName:="Training_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Training_ID As String

        <XmlElement(ElementName:="Remove_Training", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Training As String

        <XmlElement(ElementName:="Training", Namespace:="urn:com.workday/bsvc")>
        Public Property Training As String

        <XmlElement(ElementName:="Description", Namespace:="urn:com.workday/bsvc")>
        Public Property Description As String

        <XmlElement(ElementName:="Completion_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Completion_Date As String

        <XmlElement(ElementName:="Training_Duration", Namespace:="urn:com.workday/bsvc")>
        Public Property Training_Duration As String

        <XmlElement(ElementName:="Training_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Training_Type_Reference() As Training_Type_Reference()

    End Class


    <XmlRoot(ElementName:="Training", Namespace:="urn:com.workday/bsvc")>
    Public Class Training

        <XmlElement(ElementName:="Training_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Training_Reference() As Training_Reference()

        <XmlElement(ElementName:="Training_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Training_Data() As Training_Data()

    End Class


    <XmlRoot(ElementName:="Award_and_Activity_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Award_and_Activity_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Award_and_Activity_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Award_and_Activity_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Related_Position_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Related_Position_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Award_and_Activity_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Award_and_Activity_Data

        <XmlElement(ElementName:="Award_and_Activity_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Award_and_Activity_ID As String

        <XmlElement(ElementName:="Remove_Award_and_Activity", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Award_and_Activity As String

        <XmlElement(ElementName:="Title", Namespace:="urn:com.workday/bsvc")>
        Public Property Title As String

        <XmlElement(ElementName:="Sponsor_Issuer", Namespace:="urn:com.workday/bsvc")>
        Public Property Sponsor_Issuer As String

        <XmlElement(ElementName:="Start_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Start_Date As String

        <XmlElement(ElementName:="End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property End_Date As String

        <XmlElement(ElementName:="Description", Namespace:="urn:com.workday/bsvc")>
        Public Property Description As String

        <XmlElement(ElementName:="URL", Namespace:="urn:com.workday/bsvc")>
        Public Property URL As String

        <XmlElement(ElementName:="Award_and_Activity_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Award_and_Activity_Type_Reference() As Award_and_Activity_Type_Reference()

        <XmlElement(ElementName:="Related_Position_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Related_Position_Reference() As Related_Position_Reference()

    End Class


    <XmlRoot(ElementName:="Award_and_Activity", Namespace:="urn:com.workday/bsvc")>
    Public Class Award_and_Activity

        <XmlElement(ElementName:="Award_and_Activity_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Award_and_Activity_Reference() As Award_and_Activity_Reference()

        <XmlElement(ElementName:="Award_and_Activity_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Award_and_Activity_Data() As Award_and_Activity_Data()

    End Class


    <XmlRoot(ElementName:="Organization_Professional_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Organization_Professional_Affiliation_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Professional_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Professional_Affiliation_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Professional_Affiliation_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Professional_Affiliation_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Professional_Affiliation_Relationship_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Professional_Affiliation_Relationship_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Contact_Information_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Contact_Information_Data

        <XmlElement(ElementName:="Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Address_Data() As Address_Data()

        <XmlElement(ElementName:="Phone_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Phone_Data() As Phone_Data()

        <XmlElement(ElementName:="Email_Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Email_Address_Data() As Email_Address_Data()

        <XmlElement(ElementName:="Instant_Messenger_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Instant_Messenger_Data() As Instant_Messenger_Data()

        <XmlElement(ElementName:="Web_Address_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Web_Address_Data() As Web_Address_Data()

    End Class


    <XmlRoot(ElementName:="Organization_Professional_Affiliation_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Organization_Professional_Affiliation_Data

        <XmlElement(ElementName:="Professional_Affiliation_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Affiliation_ID As String

        <XmlElement(ElementName:="Remove_Professional_Affiliation", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Professional_Affiliation As String

        <XmlElement(ElementName:="Professional_Affiliation", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Affiliation As String

        <XmlElement(ElementName:="Affiliation", Namespace:="urn:com.workday/bsvc")>
        Public Property Affiliation As String

        <XmlElement(ElementName:="Begin_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Begin_Date As String

        <XmlElement(ElementName:="End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property End_Date As String

        <XmlElement(ElementName:="Professional_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Affiliation_Reference() As Professional_Affiliation_Reference()

        <XmlElement(ElementName:="Professional_Affiliation_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Affiliation_Type_Reference() As Professional_Affiliation_Type_Reference()

        <XmlElement(ElementName:="Professional_Affiliation_Relationship_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Professional_Affiliation_Relationship_Type_Reference() As Professional_Affiliation_Relationship_Type_Reference()

        <XmlElement(ElementName:="Contact_Information_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Contact_Information_Data() As Contact_Information_Data()

    End Class


    <XmlRoot(ElementName:="Organization_Membership", Namespace:="urn:com.workday/bsvc")>
    Public Class Organization_Membership

        <XmlElement(ElementName:="Organization_Professional_Affiliation_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Organization_Professional_Affiliation_Reference() As Organization_Professional_Affiliation_Reference()

        <XmlElement(ElementName:="Organization_Professional_Affiliation_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Organization_Professional_Affiliation_Data() As Organization_Professional_Affiliation_Data()

    End Class


    <XmlRoot(ElementName:="Education_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Education_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="School_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class School_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="School_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class School_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Degree_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Degree_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Degree_Completed_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Degree_Completed_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Field_Of_Study_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Field_Of_Study_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Education_Attachment_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Education_Attachment_Data

        <XmlElement(ElementName:="File_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property File_Name As String

        <XmlElement(ElementName:="Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Comment As String

        <XmlElement(ElementName:="File", Namespace:="urn:com.workday/bsvc")>
        Public Property File As String

        <XmlElement(ElementName:="Document_Category_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Document_Category_Reference() As Document_Category_Reference()

    End Class


    <XmlRoot(ElementName:="Education_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Education_Data

        <XmlElement(ElementName:="Education_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Education_ID As String

        <XmlElement(ElementName:="Remove_Education", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Education As String

        <XmlElement(ElementName:="School_Name", Namespace:="urn:com.workday/bsvc")>
        Public Property School_Name As String

        <XmlElement(ElementName:="Location", Namespace:="urn:com.workday/bsvc")>
        Public Property Location As String

        <XmlElement(ElementName:="Date_Degree_Received", Namespace:="urn:com.workday/bsvc")>
        Public Property Date_Degree_Received As String

        <XmlElement(ElementName:="Grade_Average", Namespace:="urn:com.workday/bsvc")>
        Public Property Grade_Average As String

        <XmlElement(ElementName:="First_Year_Attended", Namespace:="urn:com.workday/bsvc")>
        Public Property First_Year_Attended As String

        <XmlElement(ElementName:="Last_Year_Attended", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Year_Attended As String

        <XmlElement(ElementName:="Is_Highest_Level_of_Education", Namespace:="urn:com.workday/bsvc")>
        Public Property Is_Highest_Level_of_Education As String

        <XmlElement(ElementName:="First_Day_Attended", Namespace:="urn:com.workday/bsvc")>
        Public Property First_Day_Attended As String

        <XmlElement(ElementName:="Last_Day_Attended", Namespace:="urn:com.workday/bsvc")>
        Public Property Last_Day_Attended As String

        <XmlElement(ElementName:="Country_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Country_Reference() As Country_Reference()

        <XmlElement(ElementName:="School_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property School_Reference() As School_Reference()

        <XmlElement(ElementName:="School_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property School_Type_Reference() As School_Type_Reference()

        <XmlElement(ElementName:="Degree_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Degree_Reference() As Degree_Reference()

        <XmlElement(ElementName:="Degree_Completed_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Degree_Completed_Reference() As Degree_Completed_Reference()

        <XmlElement(ElementName:="Field_Of_Study_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Field_Of_Study_Reference() As Field_Of_Study_Reference()

        <XmlElement(ElementName:="Education_Attachment_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Education_Attachment_Data() As Education_Attachment_Data()

    End Class


    <XmlRoot(ElementName:="Education", Namespace:="urn:com.workday/bsvc")>
    Public Class Education

        <XmlElement(ElementName:="Education_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Education_Reference() As Education_Reference()

        <XmlElement(ElementName:="Education_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Education_Data() As Education_Data()

    End Class


    <XmlRoot(ElementName:="Experience_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Experience_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Experience_Rating_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Experience_Rating_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Work_Experience", Namespace:="urn:com.workday/bsvc")>
    Public Class Work_Experience

        <XmlElement(ElementName:="Remove_Experience", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Experience As String

        <XmlElement(ElementName:="Experience_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Experience_Comment As String

        <XmlElement(ElementName:="Experience_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Experience_Reference() As Experience_Reference()

        <XmlElement(ElementName:="Experience_Rating_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Experience_Rating_Reference() As Experience_Rating_Reference()

    End Class


    <XmlRoot(ElementName:="Language_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Language_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Language_Proficiency_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Language_Proficiency_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Language_Ability_Type_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Language_Ability_Type_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Language_Ability_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Language_Ability_Data

        <XmlElement(ElementName:="Language_Proficiency_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Language_Proficiency_Reference() As Language_Proficiency_Reference()

        <XmlElement(ElementName:="Language_Ability_Type_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Language_Ability_Type_Reference() As Language_Ability_Type_Reference()

    End Class


    <XmlRoot(ElementName:="Language_Ability", Namespace:="urn:com.workday/bsvc")>
    Public Class Language_Ability

        <XmlElement(ElementName:="Language_Ability_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Language_Ability_Data() As Language_Ability_Data()

    End Class


    <XmlRoot(ElementName:="Assessed_by_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Assessed_by_Worker_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Language", Namespace:="urn:com.workday/bsvc")>
    Public Class Language

        <XmlElement(ElementName:="Remove_Language", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Language As String

        <XmlElement(ElementName:="Native_Language", Namespace:="urn:com.workday/bsvc")>
        Public Property Native_Language As String

        <XmlElement(ElementName:="Assessed_On", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessed_On As String

        <XmlElement(ElementName:="Note", Namespace:="urn:com.workday/bsvc")>
        Public Property Note As String

        <XmlElement(ElementName:="Language_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Language_Reference() As Language_Reference()

        <XmlElement(ElementName:="Language_Ability", Namespace:="urn:com.workday/bsvc")>
        Public Property Language_Ability() As Language_Ability()

        <XmlElement(ElementName:="Assessed_by_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Assessed_by_Worker_Reference() As Assessed_by_Worker_Reference()

    End Class


    <XmlRoot(ElementName:="Internal_Project_Experience_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Internal_Project_Experience_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Internal_Project_Experience_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Internal_Project_Experience_Data

        <XmlElement(ElementName:="Internal_Project_Experience_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Internal_Project_Experience_ID As String

        <XmlElement(ElementName:="Remove_Internal_Project_Experience", Namespace:="urn:com.workday/bsvc")>
        Public Property Remove_Internal_Project_Experience As String

        <XmlElement(ElementName:="Internal_Project", Namespace:="urn:com.workday/bsvc")>
        Public Property Internal_Project As String

        <XmlElement(ElementName:="Description", Namespace:="urn:com.workday/bsvc")>
        Public Property Description As String

        <XmlElement(ElementName:="Start_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Start_Date As String

        <XmlElement(ElementName:="End_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property End_Date As String

        <XmlElement(ElementName:="Project_Leader", Namespace:="urn:com.workday/bsvc")>
        Public Property Project_Leader As String

    End Class


    <XmlRoot(ElementName:="Internal_Project_Experience", Namespace:="urn:com.workday/bsvc")>
    Public Class Internal_Project_Experience

        <XmlElement(ElementName:="Internal_Project_Experience_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Internal_Project_Experience_Reference() As Internal_Project_Experience_Reference()

        <XmlElement(ElementName:="Internal_Project_Experience_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Internal_Project_Experience_Data() As Internal_Project_Experience_Data()

    End Class


    <XmlRoot(ElementName:="Qualification_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Qualification_Data

        <XmlElement(ElementName:="External_Job_History", Namespace:="urn:com.workday/bsvc")>
        Public Property External_Job_History() As External_Job_History()

        <XmlElement(ElementName:="Competency", Namespace:="urn:com.workday/bsvc")>
        Public Property Competency() As Competency()

        <XmlElement(ElementName:="Certification", Namespace:="urn:com.workday/bsvc")>
        Public Property Certification() As Certification()

        <XmlElement(ElementName:="Training", Namespace:="urn:com.workday/bsvc")>
        Public Property Training() As Training()

        <XmlElement(ElementName:="Award_and_Activity", Namespace:="urn:com.workday/bsvc")>
        Public Property Award_and_Activity() As Award_and_Activity()

        <XmlElement(ElementName:="Organization_Membership", Namespace:="urn:com.workday/bsvc")>
        Public Property Organization_Membership() As Organization_Membership()

        <XmlElement(ElementName:="Education", Namespace:="urn:com.workday/bsvc")>
        Public Property Education() As Education()

        <XmlElement(ElementName:="Work_Experience", Namespace:="urn:com.workday/bsvc")>
        Public Property Work_Experience() As Work_Experience()

        <XmlElement(ElementName:="Language", Namespace:="urn:com.workday/bsvc")>
        Public Property Language() As Language()

        <XmlElement(ElementName:="Internal_Project_Experience", Namespace:="urn:com.workday/bsvc")>
        Public Property Internal_Project_Experience() As Internal_Project_Experience()

    End Class


    <XmlRoot(ElementName:="Eligible_For_Hire_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Eligible_For_Hire_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Applicant_Has_Marked_as_No_Show_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Applicant_Has_Marked_as_No_Show_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Applicant_Source_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Applicant_Source_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Referred_by_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Referred_by_Worker_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Positions_Considered_for_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Positions_Considered_for_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Recruiting_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Recruiting_Data

        <XmlElement(ElementName:="Applicant_Entered_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Entered_Date As String

        <XmlElement(ElementName:="Applicant_Comments", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Comments As String

        <XmlElement(ElementName:="Eligible_for_Rehire_Comments", Namespace:="urn:com.workday/bsvc")>
        Public Property Eligible_for_Rehire_Comments As String

        <XmlElement(ElementName:="Eligible_For_Hire_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Eligible_For_Hire_Reference() As Eligible_For_Hire_Reference()

        <XmlElement(ElementName:="Applicant_Has_Marked_as_No_Show_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Has_Marked_as_No_Show_Reference() As Applicant_Has_Marked_as_No_Show_Reference()

        <XmlElement(ElementName:="Applicant_Source_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Source_Reference() As Applicant_Source_Reference()

        <XmlElement(ElementName:="Referred_by_Worker_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Referred_by_Worker_Reference() As Referred_by_Worker_Reference()

        <XmlElement(ElementName:="Positions_Considered_for_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Positions_Considered_for_Reference() As Positions_Considered_for_Reference()

    End Class


    <XmlRoot(ElementName:="Resume_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Resume_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Resume_Data_2", Namespace:="urn:com.workday/bsvc")>
    Public Class Resume_Data_2

        <XmlElement(ElementName:="File_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property File_ID As String

        <XmlElement(ElementName:="File", Namespace:="urn:com.workday/bsvc")>
        Public Property File As String

        <XmlElement(ElementName:="FileName", Namespace:="urn:com.workday/bsvc")>
        Public Property FileName As String

        <XmlElement(ElementName:="Comments", Namespace:="urn:com.workday/bsvc")>
        Public Property Comments As String

    End Class


    <XmlRoot(ElementName:="Resume", Namespace:="urn:com.workday/bsvc")>
    Public Class _Resume

        <XmlElement(ElementName:="Resume_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Resume_Reference() As Resume_Reference()

        <XmlElement(ElementName:="Resume_Data_2", Namespace:="urn:com.workday/bsvc")>
        Public Property Resume_Data_2() As Resume_Data_2()

    End Class


    <XmlRoot(ElementName:="Resume_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Resume_Data

        <XmlElement(ElementName:="Resume", Namespace:="urn:com.workday/bsvc")>
        Public Property _Resume() As _Resume()

    End Class


    '<XmlRoot(ElementName:="Background_Check_Data", Namespace:="urn:com.workday/bsvc")>
    'Public Class Background_Check_Data

    '    <XmlElement(ElementName:="Status_Date", Namespace:="urn:com.workday/bsvc")>
    '    Public Property Status_Date As String

    '    <XmlElement(ElementName:="Status_Comment", Namespace:="urn:com.workday/bsvc")>
    '    Public Property Status_Comment As String

    '    <XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
    '    Public Property Status_Reference() As Status_Reference()

    'End Class


    <XmlRoot(ElementName:="External_Integration_ID_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class External_Integration_ID_Data

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Field_Reference", Namespace:="urn:com.workday/bsvc")>
    Public Class Field_Reference

        <XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property Descriptor As String

        <XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
        Public Property ID() As ID()

    End Class


    <XmlRoot(ElementName:="Document_Field_Result_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Document_Field_Result_Data

        <XmlElement(ElementName:="Value", Namespace:="urn:com.workday/bsvc")>
        Public Property Value As String

        <XmlElement(ElementName:="Field_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Field_Reference() As Field_Reference()

    End Class


    <XmlRoot(ElementName:="Applicant_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Applicant_Data

        <XmlElement(ElementName:="Applicant_ID", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_ID As String

        <XmlElement(ElementName:="Personal_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Personal_Data() As Personal_Data()

        <XmlElement(ElementName:="Qualification_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Qualification_Data() As Qualification_Data()

        <XmlElement(ElementName:="Recruiting_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Recruiting_Data() As Recruiting_Data()

        <XmlElement(ElementName:="Resume_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Resume_Data() As Resume_Data()

        <XmlElement(ElementName:="Background_Check_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Background_Check_Data() As Background_Check_Data()

        <XmlElement(ElementName:="External_Integration_ID_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property External_Integration_ID_Data() As External_Integration_ID_Data()

        <XmlElement(ElementName:="Document_Field_Result_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Document_Field_Result_Data() As Document_Field_Result_Data()

    End Class


    <XmlRoot(ElementName:="Applicant", Namespace:="urn:com.workday/bsvc")>
    Public Class Applicant

        <XmlElement(ElementName:="Applicant_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Reference() As Applicant_Reference()

        <XmlElement(ElementName:="Applicant_Data", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant_Data() As Applicant_Data()

    End Class


    <XmlRoot(ElementName:="Response_Data", Namespace:="urn:com.workday/bsvc")>
    Public Class Response_Data

        <XmlElement(ElementName:="Applicant", Namespace:="urn:com.workday/bsvc")>
        Public Property Applicant() As Applicant()

    End Class


    <XmlRoot(ElementName:="NewDataSet", Namespace:="urn:com.workday/bsvc")>
    Public Class NewDataSet

        <XmlAttribute(AttributeName:="version", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
        Public Property version As String

    End Class



End Namespace