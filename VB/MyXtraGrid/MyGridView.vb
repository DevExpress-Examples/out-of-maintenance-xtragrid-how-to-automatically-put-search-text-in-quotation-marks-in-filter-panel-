Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports System.Reflection
Imports DevExpress.XtraGrid.Columns

Namespace MyXtraGrid
	Public Class MyGridView
		Inherits DevExpress.XtraGrid.Views.Grid.GridView
		Private _simpleSearch As Boolean
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Property SimpleSearch() As Boolean
			Get
				Return _simpleSearch
			End Get
			Set(ByVal value As Boolean)
				_simpleSearch = value
			End Set
		End Property

		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
			' put your initialization code here
		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
		Protected Overrides Function ConvertGridFilterToDataFilter(ByVal criteria As CriteriaOperator) As CriteriaOperator
			Dim originalFindFilterText As String = Convert.ToString(GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.GetField, Nothing, Me, New Object(){}))
			If SimpleSearch Then
				If Not(String.IsNullOrEmpty(originalFindFilterText)) Then
					GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.SetField, Nothing, Me, New Object() { String.Concat("""", originalFindFilterText, """") })
				End If
				Dim findCriteria As CriteriaOperator = Nothing
				Dim _lastParserResults As FindSearchParserResults = Nothing
				If Not(String.IsNullOrEmpty(FindFilterText)) Then
					_lastParserResults = (New FindSearchParser()).Parse(FindFilterText, GetFindToColumnsCollection())
					GetType(ColumnView).GetField("lastParserResults", BindingFlags.NonPublic Or BindingFlags.Instance).SetValue(Me, _lastParserResults)
					If (Not IsServerMode) Then
						_lastParserResults.AppendColumnFieldPrefixes()
					End If
					findCriteria = DxFtsContainsHelperAlt.Create(_lastParserResults, FilterCondition.Contains, IsServerMode)
				End If
				GetType(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.SetField, Nothing, Me, New Object() { originalFindFilterText })
				Return criteria And findCriteria
			End If
			Return MyBase.ConvertGridFilterToDataFilter(criteria)
		End Function
	End Class
End Namespace
