Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

' This file covers Workday XML elements related to Background Check objects.
' These are used in multiple different transactions dealing with Background Checks.

Namespace WorkDay

	<XmlRoot(ElementName:="Comment_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Comment_Data

		<XmlElement(ElementName:="Comment", Namespace:="urn:com.workday/bsvc")>
		Public Property Comment As string

		<XmlElement(ElementName:="Worker_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Worker_Reference() As Worker_Reference()

	End Class


	<XmlRoot(ElementName:="Event_Attachment_Category_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Event_Attachment_Category_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Business_Process_Attachment_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Business_Process_Attachment_Data

		<XmlElement(ElementName:="File_Name", Namespace:="urn:com.workday/bsvc")>
		Public Property File_Name As string

		<XmlElement(ElementName:="Event_Attachment_Description", Namespace:="urn:com.workday/bsvc")>
		Public Property Event_Attachment_Description As string

		<XmlElement(ElementName:="File", Namespace:="urn:com.workday/bsvc")>
		Public Property File As string

		<XmlElement(ElementName:="Content_Type", Namespace:="urn:com.workday/bsvc")>
		Public Property Content_Type As string

		<XmlElement(ElementName:="Event_Attachment_Category_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Event_Attachment_Category_Reference() As Event_Attachment_Category_Reference()

	End Class


	<XmlRoot(ElementName:="Business_Process_Parameters", Namespace:="urn:com.workday/bsvc")>
	Public Class Business_Process_Parameters

		<XmlElement(ElementName:="Auto_Complete", Namespace:="urn:com.workday/bsvc")>
		Public Property Auto_Complete As string

		<XmlElement(ElementName:="Run_Now", Namespace:="urn:com.workday/bsvc")>
		Public Property Run_Now As string

		<XmlElement(ElementName:="Comment_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Comment_Data() As Comment_Data()

		<XmlElement(ElementName:="Business_Process_Attachment_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Business_Process_Attachment_Data() As Business_Process_Attachment_Data()

	End Class


	<XmlRoot(ElementName:="Next_Step_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Next_Step_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Disposition_Step_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Disposition_Step_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Start_Parallel_Stage_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Start_Parallel_Stage_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Dynamic_Business_Process_Parameters", Namespace:="urn:com.workday/bsvc")>
	Public Class Dynamic_Business_Process_Parameters

		<XmlElement(ElementName:="Next_Step_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Next_Step_Reference() As Next_Step_Reference()

		<XmlElement(ElementName:="Disposition_Step_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Disposition_Step_Reference() As Disposition_Step_Reference()

		<XmlElement(ElementName:="Start_Parallel_Stage_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Start_Parallel_Stage_Reference() As Start_Parallel_Stage_Reference()

		<XmlElement(ElementName:="Comment_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Comment_Data() As Comment_Data()

	End Class


	<XmlRoot(ElementName:="Recipient_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Recipient_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Event_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Event_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Background_Check_Status_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Background_Check_Status_Data

		<XmlElement(ElementName:="Status_Date", Namespace:="urn:com.workday/bsvc")>
		Public Property Status_Date As string

		<XmlElement(ElementName:="Status_Comment", Namespace:="urn:com.workday/bsvc")>
		Public Property Status_Comment As string

		<XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Status_Reference() As Status_Reference()

	End Class


	<XmlRoot(ElementName:="Package_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Package_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Package_Reference_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Package_Reference_Data

		<XmlAttribute(AttributeName:="Package_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Package_Name As string

		<XmlAttribute(AttributeName:="Package_Description", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Package_Description As string

		<XmlElement(ElementName:="Results_URL", Namespace:="urn:com.workday/bsvc")>
		Public Property Results_URL As string

		<XmlElement(ElementName:="Package_Comment", Namespace:="urn:com.workday/bsvc")>
		Public Property Package_Comment As string

		<XmlElement(ElementName:="Package_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Package_Reference() As Package_Reference()

		<XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Status_Reference() As Status_Reference()

	End Class


	<XmlRoot(ElementName:="Background_Check_Package_Test_Reference", Namespace:="urn:com.workday/bsvc")>
	Public Class Background_Check_Package_Test_Reference

		<XmlAttribute(AttributeName:="Descriptor", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Descriptor As string

		<XmlElement(ElementName:="ID", Namespace:="urn:com.workday/bsvc")>
		Public Property ID() As ID()

	End Class


	<XmlRoot(ElementName:="Test_Reference_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Test_Reference_Data

		<XmlAttribute(AttributeName:="Test_Name", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Test_Name As string

		<XmlAttribute(AttributeName:="Test_Description", Namespace:="urn:com.workday/bsvc", Form:=XmlSchemaForm.Qualified)>
		Public Property Test_Description As string

		<XmlElement(ElementName:="Background_Check_Package_Test_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Background_Check_Package_Test_Reference() As Background_Check_Package_Test_Reference()

		<XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Status_Reference() As Status_Reference()

	End Class


	<XmlRoot(ElementName:="Background_Check_Data", Namespace:="urn:com.workday/bsvc")>
	Public Class Background_Check_Data

		<XmlElement(ElementName:="Recipient_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Recipient_Reference() As Recipient_Reference()

		<XmlElement(ElementName:="Event_Reference", Namespace:="urn:com.workday/bsvc")>
		Public Property Event_Reference() As Event_Reference()

		<XmlElement(ElementName:="Background_Check_Status_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Background_Check_Status_Data() As Background_Check_Status_Data()

		<XmlElement(ElementName:="Package_Reference_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Package_Reference_Data() As Package_Reference_Data()

		<XmlElement(ElementName:="Test_Reference_Data", Namespace:="urn:com.workday/bsvc")>
		Public Property Test_Reference_Data() As Test_Reference_Data()

		<XmlElement(ElementName:="Status_Date", Namespace:="urn:com.workday/bsvc")>
        Public Property Status_Date As String

        <XmlElement(ElementName:="Status_Comment", Namespace:="urn:com.workday/bsvc")>
        Public Property Status_Comment As String

        <XmlElement(ElementName:="Status_Reference", Namespace:="urn:com.workday/bsvc")>
        Public Property Status_Reference() As Status_Reference()

		Sub New()

		End Sub

	End Class

End Namespace

