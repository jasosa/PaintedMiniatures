using MiniaturesApp.Models;

namespace MiniaturesApp.Services;

public class MiniatureService
{
    private List<PaintingProject> _paintingprojects = new()
    {
        new BoardGame
        {
            Name = "Gloomhaven",
            CoverImageUrl = "images/gloomhaven.jpg",
            Miniatures = new List<Miniature>
            {
                new Miniature { Name = "Brute", Type = "Hero", IsPainted = true },
                new Miniature { Name = "Scoundrel", Type = "Hero", IsPainted = false },
                new Miniature { Name = "Inox Guard", Type = "Enemy", IsPainted = true }
            }
        },
        new BoardGame
        {
            Name = "Zombicide",
            CoverImageUrl = "images/zombicide.jpg",
            Miniatures = new List<Miniature>
            {
                new Miniature { Name = "Fatty", Type = "Zombie", IsPainted = false },
                new Miniature { Name = "Runner", Type = "Zombie", IsPainted = false }
            }
        },
        new BoardGame
        {
            Name = "Blood Rage",
            CoverImageUrl = "images/bloodrage.jpg",
            Miniatures = new List<Miniature>
            {
                new Miniature { Name = "Viking Warrior", Type = "Hero", IsPainted = true },
                new Miniature { Name = "Sea Serpent", Type = "Monster", IsPainted = false },
                new Miniature { Name = "Fire Giant", Type = "Monster", IsPainted = true }
            }
        },
        new BoardGame
        {
            Name = "Cthulhu: Death May Die",
            CoverImageUrl = "images/cthulhu.jpg",
            Miniatures = new List<Miniature>
            {
                new Miniature { Name = "Investigator", Type = "Hero", IsPainted = false },
                new Miniature { Name = "Cultist", Type = "Enemy", IsPainted = false },
                new Miniature { Name = "Cthulhu", Type = "Elder God", IsPainted = false }
            }
        },
        new BoardGame
        {
            Name = "Star Wars: Imperial Assault",
            CoverImageUrl = "images/imperial.jpg",
            Miniatures = new List<Miniature>
            {
                new Miniature { Name = "Stormtrooper", Type = "Enemy", IsPainted = true },
                new Miniature { Name = "Darth Vader", Type = "Villain", IsPainted = false },
                new Miniature { Name = "Rebel Trooper", Type = "Hero", IsPainted = true }
            }
        },
    };

    public List<PaintingProject> GetAllPaintingProjects() => _paintingprojects;

    public PaintingProject? GetProjectByName(string name)
{
    return _paintingprojects.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}
}
