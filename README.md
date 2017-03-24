# LightDevelop
A lightweight IDE for Visual Basic .NET, which supports these features:

- Form editing & saving
- Syntax highlighting
- Code auto-finishing
- Code snippets

## Form editing

![](Markdown\formedit.PNG)

- Double click on "Add control panel" to add controls;
- Right click on controls to delete;
- Drag control to move;
- Drag "Size grip" at the corner to resize;
- You can edit the property on the grid;
	- *LightDevelop can only save these types of property:*
	- *Numbers; Booleans; Strings; Sizes; Points and Colors*
- You can save your form to a XML file by File > Save Project.
	- *Code is not included in saved file.*
	
## Code editing

![](Markdown\code.PNG)

- Click "Code" on the tool bar to open code window;
- Double click on snippet panel to insert a code snippet;
- When typing a dot (".")...
	- after a namespace like "System.IO" or just "IO", there is namespace member auto-finishing;
	- after a type like "Point" or "Drawing.Point", there is class member auto-finishing.
