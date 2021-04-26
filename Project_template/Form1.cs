using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn
{
    public partial class Form1 : Form
    {
        //khai báo enum. 
        enum FormEditState { Them,Sua,Xem }
        // nếu ko muốn dùng enum có thể khai báo là: string fES;
        FormEditState fES = FormEditState.Xem;
        string oldMaHH = string.Empty;
        string oldLH = string.Empty;
        public Form1()
        {
            InitializeComponent();
            string[] lhs = new string[] { "Dien Thoai", "Dong Ho","Laptop","May in" };
            // Thêm dữ liệu cho datagridview. cột nào ko muốn điền dữ liệu thì ghi null.
            dataGridView1.Rows.Add("hh1", "iphone 6", "apple", lhs[0], null, null);
            dataGridView1.Rows.Add("hh2", "apple watch", "apple", lhs[1], null, null);
            dataGridView1.Rows.Add("hh3", "iphone 7", "apple", lhs[0], null, null);
            dataGridView1.Rows.Add("hh4", "asus vivobook", "apple", lhs[2], null, null);
            // ko cho edit datagridview.
            dataGridView1.ReadOnly = true;
            // chỉnh trạng thái cho button
            ChangeButtonState(true); 
            // chỉ có thể select 1 row hoặc cell tại 1 thời điểm.
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnOK.Click += btnOK_Click;
            btnHuy.Click += btnHuy_Click;
            btnThoat.Click += btnThoat_Click;
            this.Height = 700;
            this.Width = 900;
            foreach (var item in lhs)
            {
                cbbLH.Items.Add(item);
                dataGridView2.Rows.Add( item,"X" );
            }
            groupBox2.Visible = false;
           
            
        }

       

        //mỗi khi select 1 dòng trong datagridview. textbox sẽ hiển thị dòng tương ứng.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // lấy index của dòng đang dc select trong datagridview.
            var cr = dataGridView1==null? null: dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;


            bool allowchanged = !(btnOK.Enabled && btnOK.Visible);
            if (rowIndex >=0 && allowchanged )
            {
                // gán các giá trị của dòng hiện tại trong datagridview vào textbox
                txtMaHH.Text = dataGridView1[0, rowIndex].Value?.ToString();
                txtTenHH.Text = dataGridView1[1, rowIndex].Value?.ToString();
                txtCty.Text = dataGridView1[2, rowIndex].Value?.ToString();
               
                cbbLH.SelectedItem = dataGridView1[3, rowIndex].Value?.ToString();
                txtNSX.Text = dataGridView1[4, rowIndex].Value?.ToString();
                txtHSD.Text = dataGridView1[5, rowIndex].Value?.ToString();
            }

        }
        // xóa dữ liệu trong textbox
        private void ResetTextBox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            txtCty.Text = string.Empty;
            //txtHangHoaTim.Text = string.Empty;
            txtNSX.Text = string.Empty;
            txtHSD.Text = string.Empty;
        }
        // chuẩn bị để thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            // gán thuộc tính fES = them. nếu fES là string thì gán fES = "them".
            fES = FormEditState.Them;
            ResetTextBox();
        }
        // chuẩn bị để sửa dữ liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow !=null)
            {
                oldMaHH = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                ChangeButtonState(false);
                fES = FormEditState.Sua;
                dataGridView1.Enabled = false;
            }
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // try catch để xử lý lỗi.Nếu ko có try catch, trong trường hợp cậu lệnh trong khối try bị lỗi, sẽ khiến chương trình bị dừng. Khi có try catch
            // chương trình vẫn tiếp tục chạy và bỏ qua lỗi đó. Những lệnh trong catch sẽ dc chạy khi có lỗi xảy ra.
            try
            {
                //show 1 cái thông điệp hỏi user có muốn xóa ko? 
                var result = MessageBox.Show("Bạn có muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo);
                if (result== DialogResult.Yes)
                {
                    // xóa dòng hiện tại của datagridview
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                //Nếu ko muốn hỏi user thì xóa hết đoạn message trên và dữ lại mỗi dòng: dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index); là đủ .

            }
            catch (Exception)
            {
                // show 1 cái thông điệp báo lỗi. Thông điệp này ko quan trọng có thể bỏ đi và để catch rỗng mà chẳng ảnh hưởng gì. 
                MessageBox.Show("Ko thể xóa nữa");
            }
           
        }
        // hủy việc thêm hoặc sửa.
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ChangeButtonState(true);
            fES = FormEditState.Xem;
            // hiển thị nội dung của dòng hiện tại trong datagridview lên từng textbox tương ứng.
            dataGridView1_SelectionChanged(null, null);
            // cho phép select datagridview.
            dataGridView1.Enabled = true;
        }
        // enabble = true: button có thể click dc. Visible = false: ko hiển thị button. readonly =true: textbox ko thể bị edit.
        private void ChangeButtonState(bool check)
        {
            btnThoat.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnThem.Enabled = check;
            btnHuy.Visible = !check;
            btnOK.Visible = !check;

            txtMaHH.ReadOnly = check;
            txtTenHH.ReadOnly = check;
            txtCty.ReadOnly = check;
            //txtHangHoaTim.ReadOnly = check;
            cbbLH.Enabled = !check;
            txtNSX.ReadOnly = check;
            txtHSD.ReadOnly = check;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime nsx;
            DateTime hsd;
            string nsxString = string.Empty;
            string hsdString = string.Empty;
            // kiểm tra xem text box có bị rỗng ko
            if (!string.IsNullOrWhiteSpace(txtNSX.Text))
            {
                //convert text thành kiểu datetime. Nếu ko convert dc check =false.
                bool check = DateTime.TryParse(txtNSX.Text, out nsx);
                if (check )
                    //convert kiểu datetime thành kiểu string, "d" là định dạng short date (là định dạng ko có giờ)
                    nsxString = nsx.ToString("d");
            }
            
            if (!string.IsNullOrWhiteSpace(txtHSD.Text))
            {
                bool check = DateTime.TryParse(txtHSD.Text, out hsd);
                if (check)
                    hsdString = hsd.ToString("d");
            }
            bool duplicateCheck = false;
            if (fES == FormEditState.Them||fES == FormEditState.Sua && oldMaHH != txtMaHH.Text)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string s = row.Cells[0].Value.ToString();
                    if (s == txtMaHH.Text)
                    {
                        duplicateCheck = true;
                        break;
                    }
                }
            }
           
            if (string.IsNullOrWhiteSpace(txtMaHH.Text))
            {
                MessageBox.Show("Mã hàng hóa rỗng!");
                return;
            }
            if (duplicateCheck )
            {
                
                MessageBox.Show("Trùng mã hàng hóa!");
                return;
            }
            //  thêm dữ liệu vào datagridview. nếu dùng string thì fES =="them";
            if (fES == FormEditState.Them)
            {
                dataGridView1.Rows.Add(txtMaHH.Text, txtTenHH.Text, txtCty.Text, cbbLH.Text,nsxString,hsdString);
            }
            // sửa dữ liệu. nếu dùng string thì fES ="sua";
            if (fES == FormEditState.Sua)
            {
                // lấy ra row hiện tại.
                var row= dataGridView1.CurrentRow;
                // update dữ liệu = giá trị của textbox . 0 là cột đầu tiên và 1 là cột tiếp theo ....
                row.Cells[0].Value = txtMaHH.Text;
                row.Cells[1].Value = txtTenHH.Text;
                row.Cells[2].Value = txtCty.Text;
                row.Cells[3].Value = cbbLH.Text;
                row.Cells[4].Value = nsxString;
                row.Cells[5].Value = hsdString;
            }
            fES = FormEditState.Xem;
            dataGridView1.Enabled = true;
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // thoát chương trình
            Application.Exit();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.IsNewRow || e.ColumnIndex !=1)
            {
                return;
            }
            bool[] checks = new bool[dataGridView2.Rows.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[3].Value.ToString();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == s)
                    {
                        checks[i] = true;
                    }
                }
            }
            if (checks[dataGridView2.CurrentRow.Index])
            {
                MessageBox.Show("Không thể xóa do có hàng hóa đang tham chiếu đến loại hàng này");
                return;
            }
            var index = dataGridView2.CurrentRow.Index;
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index>=0)
            {
                dataGridView2.Rows.RemoveAt(index);
            }
        }

        private void btnLHThem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            this.Height = dataGridView2.Height + 350;
            this.Width = dataGridView2.Width + 100;
        }

        private void BtnLHChon_Click(object sender, EventArgs e)
        {
            var cr = dataGridView2 == null ? null : dataGridView2.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;
            if (rowIndex >=0)
            {
                
                cbbLH.Items.Clear();
                for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                {
                    var row = dataGridView2.Rows[i];
                    var cell = row.Cells[0];
                    cbbLH.Items.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                if (fES!= FormEditState.Xem)
                {
                    cbbLH.SelectedItem = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                }
                else
                {
                    dataGridView1_SelectionChanged(null, null);
                }
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                txtLHTim.Text = string.Empty;
                this.Height = 700;
                this.Width = 900;
            }
        }

        private void btnLHHuy_Click(object sender, EventArgs e)
        {
            cbbLH.Items.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                var row = dataGridView2.Rows[i];
                var cell = row.Cells[0];
                cbbLH.Items.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }

            this.Height = 700;
            this.Width = 900;
            dataGridView1_SelectionChanged(null, null);
            
            txtLHTim.Text = string.Empty;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void btnLHTim_Click(object sender, EventArgs e)
        {
            TimKiem(dataGridView2,0, txtLHTim.Text);
        }

        private void btnHangHoaTim_Click(object sender, EventArgs e)
        {
            TimKiem(dataGridView1,1 ,txtHangHoaTim.Text);
        }
        private void TimKiem(DataGridView dg,int indexCol,string textSearch)
        {
            int count = dg.Rows.Count;
            if (dg.AllowUserToAddRows==true)
            {
                count -= 1;
            }
            for (int i = 0; i < count; i++)
            {
                var row = dg.Rows[i];
                var cell = row.Cells[indexCol];
                if (cell!=null)
                {
                    var cellValue = cell.Value?.ToString();
                    if (cellValue!= null && cellValue.Contains(textSearch))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

      
        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //bool[] checks = new bool[dataGridView2.Rows.Count];
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    string s = row.Cells[3].Value.ToString();
            //    for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            //    {
            //        if (dataGridView2.Rows[i].Cells[0].Value.ToString()==s)
            //        {
            //            checks[i] = true;
            //        }
            //    }
            //}

            //if (checks[dataGridView2.CurrentRow.Index])
            //{
            //    MessageBox.Show("Ko thể sửa do có hàng hóa đang tham chiếu đến loại hàng này.");
            //    e.Cancel = true;
            //}
            if (e.ColumnIndex==0)
            {
                oldLH = dataGridView2.CurrentCell.Value.ToString();
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string currentCellString = string.Empty ;
            if(dataGridView2.EditingControl is TextBox)
            {
                var tb = (TextBox)dataGridView2.EditingControl;
                currentCellString = tb.Text;
            }
            bool duplicateCheck = false;
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                var row = dataGridView2.Rows[i];
                if (dataGridView2.CurrentRow == row)
                {
                    continue;
                }
                string s = row.Cells[0].Value.ToString();
                if (s == currentCellString)
                {
                    duplicateCheck = true;
                    break;
                }
            }
            if (duplicateCheck)
            {
                MessageBox.Show("Loại hàng đã tồn tại!");
                e.Cancel = true;
                return;
            }
            if (oldLH == currentCellString)
            {
                return;
            }
            foreach (DataGridViewRow hhRow in dataGridView1.Rows)
            {
                if (hhRow.IsNewRow)
                {
                    continue;
                }
                var cellValue = hhRow.Cells[3].Value;
                if (cellValue.ToString()== oldLH)
                {
                    hhRow.Cells[3].Value = currentCellString;
                }
            }
        }

    }
    
}
