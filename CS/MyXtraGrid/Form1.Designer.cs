// Developer Express Code Central Example:
// How to create a GridView descendant class and register it for design-time use
// 
// This is an example of a custom GridView and a custom control that inherits the
// DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
// Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
// Knowledge Base article for the additional information.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E900



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
namespace MyXtraGrid
{
	public partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.myGridControl1 = new MyXtraGrid.MyGridControl();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.myGridView1 = new MyXtraGrid.MyGridView();
			this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.myGridView1).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {this.dataTable1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {this.dataColumn1});
			this.dataTable1.TableName = "Table1";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "Column1";
			// 
			// myGridControl1
			// 
			this.myGridControl1.DataSource = this.bindingSource1;
			this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myGridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.myGridControl1.Location = new System.Drawing.Point(0, 0);
			this.myGridControl1.MainView = this.myGridView1;
			this.myGridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.myGridControl1.Name = "myGridControl1";
			this.myGridControl1.Size = new System.Drawing.Size(583, 377);
			this.myGridControl1.TabIndex = 1;
			this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.myGridView1});
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "Table1";
			this.bindingSource1.DataSource = this.dataSet1;
			// 
			// myGridView1
			// 
			this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colColumn1});
			this.myGridView1.GridControl = this.myGridControl1;
			this.myGridView1.Name = "myGridView1";
			this.myGridView1.SimpleSearch = true;
			// 
			// colColumn1
			// 
			this.colColumn1.Caption = "Column1";
			this.colColumn1.FieldName = "Column1";
			this.colColumn1.Name = "colColumn1";
			this.colColumn1.Visible = true;
			this.colColumn1.VisibleIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 377);
			this.Controls.Add(this.myGridControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
//			Me.Load += New System.EventHandler(Me.Form1_Load);
			((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.myGridView1).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted event handler wireups:
			base.Load += new System.EventHandler(Form1_Load);
		}

		#endregion

		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private MyGridControl myGridControl1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private MyGridView myGridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
	}
}

