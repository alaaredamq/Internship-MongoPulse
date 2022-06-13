namespace Abstract_Factory.Factory_Method; 

class Report : Document {
    public override void CreatePages() {
        Pages.Add(new IntroductionPage());
        Pages.Add(new ResultsPage());
        Pages.Add(new ConclusionPage());
        Pages.Add(new SummaryPage());
        Pages.Add(new BibliographyPage());
    }
}