using Microsoft.EntityFrameworkCore.Diagnostics;
using SMS.app.Views.iViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.app
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();

            btnCreate.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
            }; btnRead.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
            }; btnUpdate.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
            }; btnDelete.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler CreateEvent;
        public event EventHandler ReadEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;


        public int ProgramId { get => Convert.ToInt16(txtBoxID.Text); set => txtBoxID.Text = value.ToString(); }

        public string ProgramName { get => txtBoxProgramName.Text.Trim(); set => txtBoxProgramName.Text = value.ToString(); }

        public string Description { get => txtBoxDescription.Text.Trim(); set => txtBoxDescription.Text = value.ToString(); }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
