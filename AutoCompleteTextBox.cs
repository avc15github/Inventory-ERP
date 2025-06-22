using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace AutoCompleteTextBox
{
    public class AutoCompleteTextBox : TextBox
    {
        private ListBox _listBox;
        private bool _isAdded;
        private String[] _values;
        private String _formerValue = String.Empty;
        private DataTable sourcedata;
        private string textdescription;
        private string textkey;
        private string textvalue;
        private SearchOptions searchoptions;

        public enum SearchOptions
        {
            Start,
            Between
        }

        public AutoCompleteTextBox()
        {
            InitializeComponent();
            ResetListBox();
        }

        private void InitializeComponent()
        {
            _listBox = new ListBox();
            this.KeyDown += this_KeyDown;
            this.KeyUp += this_KeyUp;

            _listBox.DoubleClick += Listbox_DoubleClick;
            _listBox.KeyDown += ListBox_KeyDown;
        }

        private void ShowListBox()
        {
            if (!_isAdded)
            {
                Form parentForm = this.FindForm(); // new line added
                parentForm.Controls.Add(_listBox); // adds it to the form
                Point positionOnForm = parentForm.PointToClient(this.Parent.PointToScreen(this.Location)); // absolute position in the form
                _listBox.Left = positionOnForm.X;
                _listBox.Top = positionOnForm.Y + Height;
                _isAdded = true;
            }
            _listBox.Visible = true;
            _listBox.BringToFront();
        }
        
        private void ResetListBox()
        {
            _listBox.Visible = false;
        }

        private void this_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateListBox();
        }

        private void this_KeyDown(object sender, KeyEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.B)
            {
                searchoptions = SearchOptions.Between;
            }
            else if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.S)
            {
                searchoptions = SearchOptions.Start;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    {
                        if (_listBox.Visible)
                        {
                            Text = _listBox.SelectedItem.ToString();
                            ResetListBox();
                            _formerValue = Text;
                            this.Select(this.Text.Length, 0);
                            e.Handled = true;
                            //this.Focus();
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex < _listBox.Items.Count - 1))
                            _listBox.SelectedIndex++;
                        e.Handled = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex > 0))
                            _listBox.SelectedIndex--;
                        e.Handled = true;
                        break;
                    }
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    if (_listBox.Visible)
                        return true;
                    else
                        return false;
                default:
                    return base.IsInputKey(keyData);
            }
        }

        private void UpdateListBox()
        {
            if (Text == _formerValue)
                return;

            _formerValue = this.Text;
            string word = this.Text;

            if (_values != null && word.Length > 0)
            {
                //string[] matches = Array.FindAll(_values, x => (x.ToLower().Contains(word.ToLower())));
                string[] matches = null;

                if (searchoptions == SearchOptions.Between)
                {
                    matches = Array.FindAll(_values, x => (x.ToLower().Contains(word.ToLower())));
                }
                else if (searchoptions == SearchOptions.Start)
                {
                    matches = Array.FindAll(_values, x => (x.ToLower().StartsWith(word.ToLower())));
                }

                if (matches.Length > 0)
                {
                    ShowListBox();
                    _listBox.BeginUpdate();
                    _listBox.Items.Clear();
                    Array.ForEach(matches, x => _listBox.Items.Add(x));
                    _listBox.SelectedIndex = 0;
                    _listBox.Height = 0;
                    _listBox.Width = 0;
                    Focus();

                    using (Graphics graphics = _listBox.CreateGraphics())
                    {
                        if (_listBox.Items.Count > 10)
                        {
                            _listBox.Height = _listBox.GetItemHeight(0) * 10;
                        }
                        else
                        {
                            _listBox.Height = _listBox.GetItemHeight(0) * (_listBox.Items.Count+1);
                        }
                        _listBox.Width = this.Width;

                        //for (int i = 0; i < _listBox.Items.Count; i++)
                        //{
                        //    if (i < 10)
                        //        _listBox.Height += _listBox.GetItemHeight(i);
                        //    // it item width is larger than the current one
                        //    // set it to the new max item width
                        //    // GetItemRectangle does not work for me
                        //    // we add a little extra space by using '_'
                        //    int itemWidth = (int)graphics.MeasureString(((string)_listBox.Items[i]) + "_", _listBox.Font).Width;
                        //    //_listBox.Width = (_listBox.Width < itemWidth) ? itemWidth : this.Width; ;
                        //    _listBox.Width = this.Width;
                        //}
                    }
                    _listBox.EndUpdate();
                }
                else
                {
                    ResetListBox();
                }
            }
            else
            {
                ResetListBox();
            }
        }

        public String[] Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
            }
        }

        public DataTable SourceData
        {
            get { return sourcedata; }
            set 
            { 
                sourcedata = value;
                if (textdescription != null)
                {
                    string[] arr = sourcedata.AsEnumerable().Select(x => x.Field<string>(textdescription)).ToArray();
                    _values = arr;
                }
            }
        }

        public string TextDescription
        {
            get { return textdescription; }
            set { textdescription = value; }
        }

        public string TextKey
        {
            get { return textkey; }
            set { textkey = value; }
        }

        public string TextValue
        {
            get { return textvalue; }
            set { textvalue = value; }
        }

        public SearchOptions SearchWhere
        {
            get { return searchoptions; }
            set { searchoptions = value; }
        }

        public List<String> SelectedValues
        {
            get
            {
                String[] result = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return new List<String>(result);
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            DataRow[] dr = sourcedata.Select(textdescription + " = '" + this.Text.Replace("'","''") + "'");

            if (dr.Length > 0)
            {
                textvalue = dr[0][0].ToString();
            }
            else
            {
                textvalue = "";
                this.Text = "";
            }

            base.OnLeave(e);
        }

        private void Listbox_DoubleClick(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndex != -1)
            {
                if (_listBox.Visible)
                {
                    Text = _listBox.SelectedItem.ToString();
                    DataRow[] dr = sourcedata.Select(textdescription + " = '" + this.Text.Replace("'", "''") + "'");

                    if (dr.Length > 0)
                    {
                        textvalue = dr[0][0].ToString();
                    }
                    ResetListBox();
                    this.Select(this.Text.Length, 0);
                    this.Focus();
                }
            }
        }

        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    {
                        if (_listBox.Visible)
                        {
                            Text = _listBox.SelectedItem.ToString();
                            ResetListBox();
                            _formerValue = Text;
                            this.Select(this.Text.Length, 0);
                            this.Focus();
                            e.Handled = true;
                        }
                        break;
                    }
            }
        }
    }
}
