namespace UmiSushi.Web.Models.Menu;

public record MenuItem(
    string Name,
    string Price,
    string Description,
    string Allergens = "",
    int? Number = null,
    List<string>? Contents = null
);

public record MenuSection(
    string Id,
    string Title,
    string Subtitle,
    List<MenuItem> Items,
    List<string>? Images = null
);
