namespace MonPorfolio.Models;

public class Project
{
    public string Title { get; set; } = "";
    public string ShortDescription { get; set; } = "";
    public string Description { get; set; } = "";

    // Une badge par technologie (au lieu d'une seule chaîne)
    public List<string> Technologies { get; set; } = new();

    // Classe Font Awesome, ex. "fas fa-mobile-alt"
    public string Icon { get; set; } = "fas fa-code";

    // Couleur de l'icône / pastille
    public string Color { get; set; } = "#0d6efd";

    // Chemin de la capture d'écran (laisser vide pour ne pas afficher d'image)
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }

    // Liens optionnels : le bouton n'apparaît que si la valeur est renseignée
    public string? DemoUrl { get; set; }
    public string? GithubUrl { get; set; }
}
