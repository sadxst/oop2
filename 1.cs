using System;
using System.Drawing;
using System.Windows.Forms;

namespace ООП_ПР3
{
    public interface IButton
    {
        void Render(Form form, int x, int y);
    }
    public class RedButton : IButton
    {
        public void Render(Form form, int x, int y)
        {
            Button btn = new Button();
            btn.Text = "Червона";
            btn.Width = 100;
            btn.Height = 40;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            form.Controls.Add(btn);
        }
    }
    public class GreenButton : IButton
    {
        public void Render(Form form, int x, int y)
        {
            Button btn = new Button();
            btn.Text = "Зелена";
            btn.Width = 100;
            btn.Height = 40;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            form.Controls.Add(btn);
        }
    }
    public class BlueButton : IButton
    {
        public void Render(Form form, int x, int y)
        {
            Button btn = new Button();
            btn.Text = "Блакитна";
            btn.Width = 100;
            btn.Height = 40;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            form.Controls.Add(btn);
        }
    }
    public interface IButtonFactory
    {
        IButton CreateButton();
    }
    public class RedButtonFactory : IButtonFactory
    {
        public IButton CreateButton() => new RedButton();
    }
    public class GreenButtonFactory : IButtonFactory
    {
        public IButton CreateButton() => new GreenButton();
    }
    public class BlueButtonFactory : IButtonFactory
    {
        public IButton CreateButton() => new BlueButton();
    }
}