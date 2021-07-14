﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public partial class OptimiserUI : UserControl
    {
        private readonly PackStructure ActivePackStructure;
        private List<OptimiserData> Optimisers { get { return ActivePackStructure.Optimisers; } }
        private bool Complete
        {
            get { return ActivePackStructure.OptimiserComplete; }
            set { ActivePackStructure.OptimiserComplete = value; }
        }
        private readonly List<OptimiserSelector> OptimiserSelectors = new List<OptimiserSelector>();
        public OptimiserUI(PackStructure ps)
        {
            InitializeComponent();
            ActivePackStructure = ps;
            if (Optimisers.Count == 0)
            {
                AddOptimiser();
            }
            else
            {
                foreach (OptimiserData OD in Optimisers)
                {
                    AddOptimiser(OD);
                }
                AddOptimiser();

            }
            GroupBox_Resize(null, null);
        }

        public void AddOptimiser()
        {
            AddOptimiser(null);
        }

        public void AddOptimiser(OptimiserData optimiser)
        {
            OptimiserSelector OS = new OptimiserSelector
            {
                Value = optimiser,
                Dock = DockStyle.Top,
                Padding = new Padding(4, 0, 4, 0)
            };
            OS.ValueUpdate += OptimiserSelector_ValueUpdate;
            OS.RemoveThis += OptimiserSelector_RemoveThis;
            OS.MaximumSize = new Size(5000, OS.Height + 5);
            OS.MinimumSize = new Size(0, OS.Height + 5);
            GroupBox.Controls.Add(OS);
            OptimiserSelectors.Add(OS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height + 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height + 26);
        }

        private void UpdateOptimisers()
        {
            Optimisers.Clear();
            foreach (OptimiserSelector OS in OptimiserSelectors)
            {
                if (OS.Value != null)
                {
                    Optimisers.Add(OS.Value);
                }
            }
        }

        private void OptimiserSelector_ValueUpdate(object sender, EventArgs e)
        {
            if (OptimiserSelectors[OptimiserSelectors.Count - 1].Value != null)
            {
                AddOptimiser();
            }
            UpdateOptimisers();
        }

        private void OptimiserSelector_RemoveThis(object sender, EventArgs e)
        {
            Remove_OptimiserSelector((OptimiserSelector)sender);
            if (OptimiserSelectors.Count == 0 || OptimiserSelectors[OptimiserSelectors.Count - 1].Value != null)
            {
                AddOptimiser();
            }
            UpdateOptimisers();
        }

        private void Remove_OptimiserSelector(OptimiserSelector OS)
        {
            OS.Parent.Controls.Remove(OS);
            OptimiserSelectors.Remove(OS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height - 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height - 26);
            this.Height = 0;
        }

        private void GroupBox_Resize(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(5000, 40 + (OptimiserSelectors.Count * 26));
            this.MinimumSize = new Size(0, 40 + (OptimiserSelectors.Count * 26));
            ConfirmButton.Top = Math.Min(this.Height - 3, this.Height - 26);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Complete)
            {
                Complete = false;
                ConfirmButton.Text = "Confirm";
                foreach (OptimiserSelector OS in OptimiserSelectors.ToList())
                {
                    OS.ReadOnly = false;
                }
                AddOptimiser();

            }
            else
            {
                Complete = true;
                ConfirmButton.Text = "Edit";
                foreach (OptimiserSelector OS in OptimiserSelectors.ToList())
                {
                    if (OS.Value == null)
                    {
                        Remove_OptimiserSelector(OS);
                    }
                    else
                    {
                        OS.ReadOnly = true;
                    }
                }
            }

        }
    }
}