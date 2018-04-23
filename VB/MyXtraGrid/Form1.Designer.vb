' Developer Express Code Central Example:
' How to create a GridView descendant class and register it for design-time use
' 
' This is an example of a custom GridView and a custom control that inherits the
' DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
' Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
' Knowledge Base article for the additional information.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E900




Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports System
Namespace MyXtraGrid
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.myGridControl1 = New MyXtraGrid.MyGridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.myGridView1 = New MyXtraGrid.MyGridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.bindingSource1
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(583, 377)
			Me.myGridControl1.TabIndex = 1
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumn1})
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			Me.myGridView1.SimpleSearch = True
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(583, 377)
			Me.Controls.Add(Me.myGridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

'INSTANT C# NOTE: Converted event handler wireups:
'			MyBase.Load += New System.EventHandler(Form1_Load);
		End Sub

		#End Region

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private myGridControl1 As MyGridControl
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private myGridView1 As MyGridView
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

