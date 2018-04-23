using System;
using DevExpress.Data.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Base;
using System.Reflection;
using DevExpress.XtraGrid.Columns;

namespace MyXtraGrid {
    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        private bool _simpleSearch;
        public MyGridView()
            : this(null) {
        }
        public bool SimpleSearch {
            get {
                return _simpleSearch;
            }
            set {
                _simpleSearch = value;
            }
        }

        public MyGridView(DevExpress.XtraGrid.GridControl grid)
            : base(grid) {
            // put your initialization code here
        }
        protected override string ViewName {
            get {
                return "MyGridView";
            }
        }
        protected override CriteriaOperator ConvertGridFilterToDataFilter(CriteriaOperator criteria) {
            string originalFindFilterText = Convert.ToString(typeof(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, this, new object[0]));
            if (SimpleSearch) {
                if (!(string.IsNullOrEmpty(originalFindFilterText))) {
                    typeof(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField, null, this, new object[] { string.Concat("\"", originalFindFilterText, "\"") });
                }
                CriteriaOperator findCriteria = null;
                FindSearchParserResults _lastParserResults = null;
                if (!(string.IsNullOrEmpty(FindFilterText))) {
                    _lastParserResults = (new FindSearchParser()).Parse(FindFilterText, GetFindToColumnsCollection());
                    typeof(ColumnView).GetField("lastParserResults", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(this, _lastParserResults);
                    if (!IsServerMode) {
                        _lastParserResults.AppendColumnFieldPrefixes();
                    }
                    findCriteria = DxFtsContainsHelperAlt.Create(_lastParserResults, FilterCondition.Contains, IsServerMode);
                }
                typeof(ColumnView).InvokeMember("findFilterText", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField, null, this, new object[] { originalFindFilterText });
                return criteria & findCriteria;
            }
            return base.ConvertGridFilterToDataFilter(criteria);
        }
    }
}
