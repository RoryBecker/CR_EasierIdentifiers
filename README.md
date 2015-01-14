'Easier Identifiers' for CodeRush
=== 

Plugin to convert spaces into shift keys during the creation of identifiers.

Configuration 
=== 
Aside from you'll also need to do some minimal configuration to get this plugin to function.

Use the [shortcuts options page](http://community.devexpress.com/blogs/rorybecker/archive/2010/10/05/binding-keys-in-coderush.aspx) to locate the **TemplateExpand** binding (**Code\Expansion\[[Space]]** by default) and add a requirement that **System\ConvertingSpacesToCamelCase** is false.

Usage
===

With the caret in a **TextField**, type it's name using spaces instead of shift keys. Any characters following the space will be converted into uppercase.

Thus typing **my[space]variable[space]name** will result in **MyVariableName**

