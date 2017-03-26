# LightDevelop
A lightweight IDE for Visual Basic .NET, which 
**does not depends any third-party libraries** such like:

- [.NET Compiler Platform ("Roslyn")](https://github.com/dotnet/roslyn) or
- [AvalonEdit](https://github.com/icsharpcode/AvalonEdit)

...and supports these features:

- Form editing & saving
- Syntax highlighting
- Code auto-finishing
- Code snippets

## Form editing

![](https://github.com/Knowif/LightDevelop/raw/master/Markdown/formedit.png)

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

![](https://github.com/Knowif/LightDevelop/raw/master/Markdown/code.png)

- Click "Code" on the tool bar to open code window;
- Double click on snippet panel to insert a code snippet;
- When typing a dot (".")...
	- after a namespace like "System.IO" or just "IO", there is namespace member auto-finishing;
	- after a type like "Point" or "Drawing.Point", there is class member auto-finishing.

**Note:** A much more complex code-editing control is under developing in [this branch](https://github.com/Knowif/LightDevelop/tree/EditControls).
