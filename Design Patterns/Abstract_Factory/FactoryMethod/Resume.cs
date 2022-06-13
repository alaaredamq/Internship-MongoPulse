namespace Abstract_Factory.Factory_Method; 

class Resume : Document {
    public override void CreatePages() {
        Pages.Add(new SkillsPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
    }
}