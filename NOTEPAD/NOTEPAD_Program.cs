
//FIRST READ ALL THE COMMENTED TAG.......................................


//OPEN FILE DIALOG...   (HAVE TO ADD " OPENFILE DIALOG "  FROM TOOLBOX..........)

//The Below using System.IO; is Mandetory to use......

using System.IO;
private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create one empty string 
            var cont = string.Empty;

            //create object for openfile Dialog 
            OpenFileDialog ofd = new OpenFileDialog();

            //optional to avoid multi-selection of file
            ofd.Multiselect = false;
            ofd.ValidateNames = true;

            //filter to open file
            ofd.Filter = "Text Document | *.txt";


            ofd.Title = "Select Txt Files";

            //condition to open dialog box
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sm = new StreamReader(ofd.FileName);
                cont = sm.ReadToEnd();

            }
            richTextBox1.Text = cont;
        }
		
		
//SAVE FILE DIALOG...   (HAVE TO ADD " SAVEFILE DIALOG "  FROM TOOLBOX..........)
		
		
		
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create one empty string 
            var cont = string.Empty;

            //create object for openfile Dialog 
            OpenFileDialog ofd = new OpenFileDialog();

            //optional to avoid multi-selection of file
            ofd.Multiselect = false;
            ofd.ValidateNames = true;

            //filter to open file
            ofd.Filter = "Text Document | *.txt";


            ofd.Title = "Select Txt Files";

            //condition to open dialog box
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sm = new StreamReader(ofd.FileName);
                cont = sm.ReadToEnd();

            }
            richTextBox1.Text = cont;
        }
		
		
	
//FONT DIALOG...   (HAVE TO ADD " FONT DIALOG "  FROM TOOLBOX..........)	
		
private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    fontDialog1.ShowDialog();
                    

                    richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
             
        }
		
		
	

//PRINT PRIVIEW DIALOG,  PRINT DIALOG ...   (HAVE TO ADD " PRINTPRIVIEW DIALOG ", "PRINT DAILOG",  AND "PRINT DOCUMENT" FROM TOOLBOX..........)


 private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
		
		
		
private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
		
//UNDO TEXT....

 private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
		
		
//SELECT ALL TEXT....

private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }


	
//DELETE TEXT....

private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }


		
//COPY SELECTED TEXT....

 private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();
        }
		

//CUT SELECTED TEXT....

private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


//FOR EXIT....
this.Close();