﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lib.Web.Mvc.JQuery.JqGrid
{
    /// <summary>
    /// jqGrid options
    /// </summary>
    public class JqGridOptions
    {
        #region Fields
        private List<JqGridColumnModel> _columnsModel;
        private List<string> _columnsNames;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the grid identifier which will be used for table (id='{0}'), pager div (id='{0}Pager') and in JavaScript.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the value indicating if cell editing is enabled
        /// </summary>
        public bool? CellEditingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the cell editing submit mode
        /// </summary>
        public JqGridCellEditingSubmitModes? CellEditingSubmitMode { get; set; }

        /// <summary>
        /// Gets or set the URL for cell editing submit
        /// </summary>
        public string CellEditingUrl { get; set; }

        /// <summary>
        /// Gets the list of columns parameters descriptions.
        /// </summary>
        public List<JqGridColumnModel> ColumnsModels { get { return _columnsModel; } }

        /// <summary>
        /// Gets the list of columns names.
        /// </summary>
        public List<string> ColumnsNames { get { return _columnsNames; } }

        /// <summary>
        /// Gets or sets the list of columns indexes for remaping (default null).
        /// </summary>
        public List<int> ColumnsRemaping { get; set;  }

        /// <summary>
        /// Gets or sets the string of data which will be used when DataType is set to JqGridDataTypes.XmlString or JqGridDataTypes.JsonString (default null).
        /// </summary>
        public string DataString { get; set; }

        /// <summary>
        /// Gets or sets the type of information to expect to represent data in the grid (default JqGridDataTypes.Xml).
        /// </summary>
        public JqGridDataTypes DataType { get; set; }

        /// <summary>
        /// Gets or sets the url for inline and form editing.
        /// </summary>
        public string EditingUrl { get; set; }

        /// <summary>
        /// Gets or sets the value which defines whether the tree is expanded and/or collapsed when user clicks on the text of the expanded column, not only on the image.
        /// </summary>
        public bool? ExpandColumnClick { get; set; }

        /// <summary>
        /// Gets or sets the name of column which should be used to expand the tree grid.
        /// </summary>
        public string ExpandColumn { get; set; }

        /// <summary>
        /// Gets or sets the height of the grid in pixels (default 'auto').
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the type of request to make (default JqGridMethodTypes.Get).
        /// </summary>
        public JqGridMethodTypes MethodType { get; set; }

        /// <summary>
        /// Gets or sets the name of the function for event which is raised immediately after row was clicked.
        /// </summary>
        public string OnSelectRow { get; set; }

        /// <summary>
        /// Gets or sets if grid should use a pager bar to navigate through the records (default: false).
        /// </summary>
        public bool Pager { get; set; }

        /// <summary>
        /// Gets or sets how many records should be displayed in the grid (default 20).
        /// </summary>
        public int RowsNumber { get; set; }

        /// <summary>
        /// Gets or sets the initial sorting column index, when  using data returned from server (default: String.Empty)
        /// </summary>
        public string SortingName { get; set; }

        /// <summary>
        /// Gets or sets the initial sorting order, when  using data returned from server (default JqGridSortingOrders.Asc)
        /// </summary>
        public JqGridSortingOrders SortingOrder { get; set; }

        /// <summary>
        /// Gets or sets the value which defines if subgrid is enabled.
        /// </summary>
        public bool? SubgridEnabled { get; set; }

        /// <summary>
        /// Gets or sets the subgrid model.
        /// </summary>
        public JqGridSubgridModel SubgridModel { get; set; }

        /// <summary>
        /// Gets or sets the url for subgrid data requests.
        /// </summary>
        public string SubgridUrl { get; set; }

        /// <summary>
        /// Gets or sets the width of subgrid expand/colapse column.
        /// </summary>
        public int? SubgridColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the value which defines if TreeGrid is enabled.
        /// </summary>
        public bool? TreeGridEnabled { get; set; }

        /// <summary>
        /// Gets or sets the model for TreeGrid.
        /// </summary>
        public JqGridTreeGridModels? TreeGridModel { get; set; }

        /// <summary>
        /// Gets or sets the url for data requests (default null)
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets if grid should display the beginning and ending record number out of the total number of records in the query (default: false)
        /// </summary>
        public bool ViewRecords { get; set; }

        /// <summary>
        /// Gets or sets the width of the grid in pixels (default 'auto').
        /// </summary>
		public int? Width { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the JqGridOptions class.
        /// </summary>
        /// <param name="id">Identifier, which will be used for table (id='{0}'), pager div (id='{0}Pager'), filter grid div (id='{0}Search') and in JavaScript.</param>
        public JqGridOptions(string id)
        {
            Id = id;
            _columnsModel = new List<JqGridColumnModel>();
            _columnsNames = new List<string>();

            ColumnsRemaping = null;
            DataType = JqGridDataTypes.Xml;
            DataString = null;
            Height = null;
            MethodType = JqGridMethodTypes.Get;
            Pager = false;
            RowsNumber = 20;
            SortingName = String.Empty;
            SortingOrder = JqGridSortingOrders.Asc;
            Url = null;
            ViewRecords = false;
            Width = null;
        }
        #endregion

        #region Methods
        internal bool UseDataString()
        {
            return (this.DataType == JqGridDataTypes.JsonString || this.DataType == JqGridDataTypes.XmlString);
        }
        #endregion
    }
}