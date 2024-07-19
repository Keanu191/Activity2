using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // linked list of cars
        LinkedList<string> myCarCollection = new LinkedList<string>();

        private void buttonAddFirst_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.AddFirst(textBoxCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a Car name!");
            }
        }

        // method to display the linked list in the list box
        private void showLinkedList()
        {
            // clear input boxes and list box
            listBox1.Items.Clear();
            textBoxCarName.Clear();
            textBoxNodePosition.Clear();
            // display number of list nodes
            textBoxNumOfNodes.Text = numberOfNodes().ToString(); 
            // display linked list
            foreach (string car in myCarCollection)
            {
                listBox1.Items.Add(car);
            }
        }

        private int numberOfNodes()
        {
            return myCarCollection.Count;
        }

        private void buttonAddLast_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.AddLast(textBoxCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a Car name");
            }
        }

        private void buttonAddBefore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text) && (!string.IsNullOrEmpty(textBoxNodePosition.Text)))
            {
                LinkedListNode<string> current = myCarCollection.Find(textBoxNodePosition.Text);
                myCarCollection.AddBefore(current, textBoxCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a Car name and Node position!");
            }
        }

        private void buttonAddAfter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text) &&
                (!string.IsNullOrEmpty(textBoxNodePosition.Text)))
            {
                LinkedListNode<string> current = myCarCollection.Find(textBoxNodePosition.Text);
                myCarCollection.AddAfter(current, textBoxCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a Car name and Node position!");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.Remove(textBoxCarName.Text);
                showLinkedList();
            }
            else
            {
                MessageBox.Show("Please enter a Car name");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            myCarCollection.Clear();
            showLinkedList();
        }
    }
}
