using System;

namespace MyCalculator
{
    public delegate void UpdatedEventHandler(object sender, EventArgs e);

    internal class InputHandler
    {
        public event UpdatedEventHandler Updated;
        public string Input { get; private set; }

        public InputHandler()
        {
            Input = "";
        }

        public void ResetInput()
        {
            SetInput("");
        }

        private void SetInput(String Input)
        {
            if (this.Input == Input)
                return;

            this.Input = Input;
            Updated(this, new EventArgs());
        }
    }
}