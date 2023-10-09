using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
   
    public partial class Form1 : Form
    {
       ArrayList list1 = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }
        public class Employee
        {
            private string id { get; set; }
            private string name { get; set; }
            private string ngsinh { get; set; }
            private string gioitinh { get; set; }
            private string diachi { get; set; }
            private string email { get; set; }
            private string dt { get; set; }
        }
        public List<Employee> GetData() 
        {
            List<Employee> list = new List<Employee>();
            Employee employee = new Employee();
            list.Add(employee);
            return list;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
          
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(id.Text, dt.Text, name.Text, ngaysinh.Text, dc.Text,email.Text, gioitinh.Checked);
            if(id.Text =="" || name.Text=="")
            {
               MessageBox.Show("Khong duoc bo trong", "Error", MessageBoxButtons.OK);
                return;
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(idx);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        { 
            int idx = e.RowIndex;
            id.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            name.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString(); 
            email.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            dc.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            ngaysinh.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            dt.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            if (gioitinh.Checked == true)
            {
                gioitinh.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[6].Value.ToString());
              
            }
            else
            {
                nu.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[6].Value.ToString());
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}
  

