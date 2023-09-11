
// class for adding the labels that display a characters information
using SuperAdventure;

public class FormLabels {

    Form1 form;

    public FormLabels(Form1 form){ 
        this.form = form;
        createFormLabels();

    }
    
    private void createFormLabels(){
        CreateLabel hp = new CreateLabel("Hit Points:", 18, 20, 8.25f, Color.Black);
        form.Controls.Add(hp.getLabel());

        CreateLabel gold = new CreateLabel("Gold:", 18, 46, 8.25f, Color.Black);
        form.Controls.Add(gold.getLabel());

        CreateLabel exp = new CreateLabel("Experience:", 18, 74, 8.25f, Color.Black);
        form.Controls.Add(exp.getLabel());

        CreateLabel lvl = new CreateLabel("Level:", 18, 100, 8.25f, Color.Black);
        form.Controls.Add(lvl.getLabel());

        CreateLabel lblHitPoints = new CreateLabel("", 110, 19, 8.25f, Color.Black);
        form.Controls.Add(lblHitPoints.getLabel());

        CreateLabel lblGold = new CreateLabel("", 110, 45, 8.25f, Color.Black);
        form.Controls.Add(lblGold.getLabel());

        CreateLabel lblExperience = new CreateLabel("", 110, 73, 8.25f, Color.Black);
        form.Controls.Add(lblExperience.getLabel());

        CreateLabel lblLevel = new CreateLabel("", 110, 99, 8.25f, Color.Black);
        form.Controls.Add(lblLevel.getLabel());

    }
}