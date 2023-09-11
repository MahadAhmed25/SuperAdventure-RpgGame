
class CreateLabel {

    private Label mylab;
    private String labelText;
    private int locationX;
    private int locationY;
    private float fontSize;
    private Color textColor;
    

    public CreateLabel(String labelText, int locationX, int locationY, float fontSize, Color textColor) {
        this.labelText = labelText;
        this.locationX = locationX;
        this.locationY = locationY;
        this.fontSize = fontSize;
        this.textColor = textColor;
        makeLabel();
    }

    private void makeLabel(){
        // Creating and setting the label
        mylab = new Label();
        mylab.Text = labelText;
        mylab.Location = new Point(locationX, locationY);
        mylab.AutoSize = true;
        mylab.Font = new Font("Calibri", fontSize);
        mylab.ForeColor = textColor;
        mylab.Padding = new Padding(6);
    }

    public Label getLabel(){
        return mylab;
    }
}