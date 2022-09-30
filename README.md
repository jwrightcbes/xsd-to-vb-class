# xsd-to-vb-class
This was my quick way to write code for heavily annotated vb classes that would serialize to XML for Workday transactions. 
This is not super user friendly, but if you want to create classes that look like these, you can use this. 

## Overview
* The code is in Program.vb and pretty well annotated on how to use it. 
* Main() calls three methods
  *  GenerateVbClasses() - Generates vb class code based on xml schema and dumps it in a .txt in a specified directory. Comment in/out based on what you are doing.
  *  Deserialize() - After you've refined your vb classes, you can use this to test that XML is deserialized properly. Comment in/out based on what you are doing.
  *  Serialize() - After you've refinded your vb classes, you can use this to test that your vb class object is serialized properly.  Comment in/out based on what you are doing.
  *  If you have an original sample XML, you can generate the classes, Deserialize() your sample XML, Serialize() your deserialized object, and compare the resulting XML to the original sample. If everything goes well, they will match. If not, this will highlight the changes needed. 
* You'll be getting XML from elsewhere if you are using this, but there is stuff stocked in there as examples to start with. You can store any of this anywhere you like. Jessa stored things like this. File paths are hardcoded, so you will have to change them because you are not using Jessa's computer. 
  * SampleXml/ - Sample XML that follows the schema we are creating the vb classes for. These are used for testing serialization/deserialization. 
  * XSD/ - The XSD file from example XML, saved as XML, described more below
  * VbClassFileOutput/ - The .txt files of generated vb class code.
  * ResultModelClasses/ - Full proper class files based on the generated vb class code, then refined as needed.
  * SerializedXml/ - Output of XML after deserializing sample XML with the new classes and serializing it again. Ideally this will match the original sample in SampleXml/

## Use
This was made for Workday specifically. Workday offers example schema XML in their documentation. https://community.workday.com/sites/default/files/file-hosting/productionapi/index.html
* Individual endpoints have downloads of XML example schema. Download that. Save it somewhere. 
* Run the Visual Studio XML Schema definition tool to generate an XSD file. 
  * In VS -> Tools -> Command Line -> Developer Command Prompt
  * In the command prompt, in the directory of your XML file: `xsd {XML file name}`
  * That will drop an XSD file in that directory with the same name as your XML file.
* Rename the XSD file to something with an XML file extension and put it in a place. We will call this the schema XML. (An XSD should be valid XML. If you have an XSD in your solution, VS will do weird stuff with it that Jessa doesn't want to deal with, which is why we are using an XML of an XSD.)
* Set the params for GenerateVbClasses() according to the location of your schema XML file and where you want the output file.
* The name of the resulting file of vb classes is yyyy-MM-dd__hh-mm__vb-class.txt.
  * The resulting file of vb classes will only have the classes; no imports or namespaces. 
  * It will likely need refining; protected names aren't addressed here, mistakes are made, type names aren't always capitalized, constructors aren't included.
  * The finalized, refined classes based off this generated code are in ResultModelClasses/
