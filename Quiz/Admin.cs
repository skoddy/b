using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Admin : Form
    {
        MySQLDatabase _db;
        List<Categories> listCategories;
        List<Answers> listAnswers;
        public Admin(MySQLDatabase db)
        {
            _db = db;
            InitializeComponent();
            
            fillCatLB();
        }
       
        private void fillCatLB()
        {
            listCategories = _db.CreateListFromTable<Categories>("categories");
            lbCat.Items.Clear();
            foreach (Categories item in listCategories)
            {
                lbCat.Items.Add(item.Name);
            }
        }

        private void fillCatItemsLB()
        {
            listAnswers = _db.CreateListFromTable<Answers>("answers");
            lbCatItems.Items.Clear();
            foreach (Answers item in listAnswers)
            {
                lbCatItems.Items.Add(item.Answer);
            }
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            int index = lbCat.SelectedIndex;

            _db.Delete("categories", listCategories[index].Id);
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            _db.Create("categories", new Categories(0, tbNewCat.Text));
            fillCatLB();
        }

        private void btnAddToCat_Click(object sender, EventArgs e)
        {
            _db.Create("answers", new Answers(0, tbNewAnswer.Text));
            fillCatLB();
        }

        private void lbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCatItemsLB();
        }
    }
}
