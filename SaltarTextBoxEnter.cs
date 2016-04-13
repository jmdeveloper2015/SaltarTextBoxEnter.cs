private void TxtPruebaENTER_KeyPress(object sender, KeyPressEventArgs e)
{
  if (e.KeyChar == (char)(Keys.Enter))
  {
     e.Handled = true;
     SendKeys.Send("{TAB}");
  }
}
