'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Slides
Imports System.Drawing

Namespace ApplyingCustomColorSchemeToSlides
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Access Presentation
			Dim pres As New Presentation(dataDir & "demo.ppt")

			'Set Color at different indices

			pres.MainMaster.SetSchemeColor(0, Color.Aqua)
			pres.MainMaster.SetSchemeColor(1, Color.Azure)
			pres.MainMaster.SetSchemeColor(2, Color.Bisque)
			pres.MainMaster.SetSchemeColor(3, Color.BlueViolet)
			pres.MainMaster.SetSchemeColor(4, Color.Brown)
			pres.MainMaster.SetSchemeColor(5, Color.DarkBlue)
			pres.MainMaster.SetSchemeColor(6, Color.DarkTurquoise)
			pres.MainMaster.SetSchemeColor(7, Color.ForestGreen)
			pres.MainMaster.SetSchemeColor(8, Color.Gainsboro)

			' Or set scheme color using ColorSchemeIndex enumeration. Use any one option

			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Accent1, Color.Aqua)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Accent2, Color.Azure)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Accent3, Color.Bisque)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Background1, Color.BlueViolet)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Background2, Color.Brown)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Fill, Color.DarkBlue)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Text1, Color.DarkTurquoise)
			pres.MainMaster.SetSchemeColor(ColorSchemeIndex.Text2, Color.ForestGreen)

			'Save Presentation
			pres.Write(dataDir & "modified.ppt")
		End Sub
	End Class
End Namespace