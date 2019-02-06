using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XZPaint
{
    public partial class SizeForm : Form
    {
        Form1 OwnerForm;
        public SizeForm(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Bitmap bm_source = new Bitmap(OwnerForm.pictureBox1.Image);
            OwnerForm.ModifiedImageSize = new Size(Convert.ToInt32(WidthNumericUpDown1.Value), Convert.ToInt32(HeightNumericUpDown2.Value));
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(OwnerForm.ModifiedImageSize.Width), Convert.ToInt32(OwnerForm.ModifiedImageSize.Height));
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);

            OwnerForm.pictureBox1.Image = bm_dest;
            OwnerForm.pictureBox1.Width = bm_dest.Width;
            OwnerForm.pictureBox1.Height = bm_dest.Height;

            this.Close();
        }

        private void SizeForm_Shown(object sender, EventArgs e)
        {
            WidthNumericUpDown1.Value = OwnerForm.pictureBox1.Width;
            HeightNumericUpDown2.Value = OwnerForm.pictureBox1.Height;
        }
    }
}
