using UmiSushi.Web.Models.Menu;

namespace UmiSushi.Web.Services;

/// <summary>
/// Statisk menudata for UmiSushi Ry.
/// TODO: Overvej migration til JSON-fil eller CMS ved hyppige ændringer.
/// Ansvarlig opdatering: Kontakt info@umisushi.dk
/// </summary>
public class MenuDataService
{
    public List<MenuSection> GetAllSections() => new()
    {
        Forretter(),
        SashimiMenuer(),
        Sashimi(),
        NigiriClassics(),
        NigiriDeluxe(),
        Gunkan(),
        UraMaki(),
        KaburiMaki(),
        HusomaikiClassic(),
        HusomaikiUmi(),
        Futomaki(),
        NoneSushiRetter(),
        Rispapir(),
        Menuer(),
        Dips(),
        Dessert(),
        Drikkekort(),
    };

    // ─── FORRETTER ───────────────────────────────────────────────
    private MenuSection Forretter() => new(
        Id: "forretter",
        Title: "Forretter",
        Subtitle: "Henvend dig til personalet med spørgsmål om allergener",
        Images: new() { "/images/menu/forretter1.jpg", "/images/menu/forretter2.jpg", "/images/menu/forretter3.jpg" },
        Items: new()
        {
            new("Crispy Ebi", "45 kr.", "3 stk. Crispy ebi med chilimayonaise", "skaldyr, gluten", 1),
            new("Crispy N' Spice Chicken", "55 kr.", "5 stk. Crispy og spicy kylling", "gluten", 2),
            new("Flamberet Laks", "79 kr.", "5 skiver flamberet laks med hvidløg, på rucolasalat, toppet med unagi, soyamayo og ørredrogn", "", 4),
            new("Misosuppe", "39 kr.", "Misosuppe med tofu, tang, forårsløg og fisk", "", 5),
            new("Tangsalat", "39 kr.", "Tangsalat toppet med radiser, kimchi drys og honningristede solsikkekerner", "", 6),
            new("Edamamebønner", "39 kr.", "Edamamebønner med havsalt, sesam og lime", "", 7),
            new("Spicy Edamamebønner", "45 kr.", "Spicy edamamebønner med havsalt, chilimayo, sriracha og kimchi drys", "æg", 8),
            new("5 stk. Gyoza", "59 kr.", "Sprødstegte dumplings med grøntsags/kyllingefyld, toppes med chili mayo, unagisauce og purløg", "gluten", 9),
        }
    );

    // ─── SASHIMI MENUER ──────────────────────────────────────────
    private MenuSection SashimiMenuer() => new(
        Id: "sashimi-menuer",
        Title: "Sashimi Menuer",
        Subtitle: "Skaldyrsallergener",
        Items: new()
        {
            new("Sashimi Mix 12 stk.", "199 kr.", "3× laks, 3× tun, 2× hamachi, 2× søde rejer, 2× tigerrejer", "skaldyr"),
            new("Sashimi Mix Deluxe 16 stk.", "249 kr.", "4× laks, 2× tun, 2× hvidfisk, 2× flamberet laks, 2× søde rejer, 2× tigerrejer, 2× gunkan tuntartar", "skaldyr"),
        }
    );

    // ─── SASHIMI ─────────────────────────────────────────────────
    private MenuSection Sashimi() => new(
        Id: "sashimi",
        Title: "Sashimi",
        Images: new() { "/images/menu/sashimi1.jpg" },
        Subtitle: "Serveres med salatmix, tangsalat, avokado, ørredrogn, wasabi og ingefær",
        Items: new()
        {
            new("Laks Sashimi", "119 kr.", "5 skiver laks sashimi"),
            new("Tun Sashimi", "119 kr.", "Tun sashimi"),
            new("Hamachi King Fish Sashimi", "119 kr.", "Hamachi King Fish sashimi"),
        }
    );

    // ─── NIGIRI CLASSICS ─────────────────────────────────────────
    private MenuSection NigiriClassics() => new(
        Id: "nigiri-classics",
        Title: "Nigiri Classics",
        Images: new() { "/images/menu/nigiriclassic1.jpg" },
        Subtitle: "2 stk. – vælg valgfrit 2 nigiri til samme pris",
        Items: new()
        {
            new("Nigiri Laks", "45 kr.", "2 stk. nigiri med laks"),
            new("Nigiri Tun", "45 kr.", "2 stk. nigiri med tun"),
            new("Nigiri Avokado", "45 kr.", "2 stk. nigiri med avokado"),
            new("Nigiri Syltet Japansk Radise (Daikon)", "45 kr.", "2 stk. nigiri med japansk radise"),
            new("Nigiri Mango", "45 kr.", "2 stk. nigiri med mango"),
            new("Nigiri Tigerrejer", "45 kr.", "2 stk. nigiri med tigerrejer", "skaldyr"),
        }
    );

    // ─── NIGIRI DELUXE ───────────────────────────────────────────
    private MenuSection NigiriDeluxe() => new(
        Id: "nigiri-deluxe",
        Title: "Nigiri Deluxe",
        Images: new() { "/images/menu/nigirideluxe1.jpg" },
        Subtitle: "Pr. stk.",
        Items: new()
        {
            new("Nigiri Hvidfisk", "26 kr.", "Nigiri hvidfisk, toppet med skovsyrer, chilimayo og sort masago"),
            new("Nigiri Sød Ebi (Søde Rejer)", "26 kr.", "Nigiri sød ebi toppet med skovsyrer, chilimayo og sort masago", "skaldyr"),
            new("Nigiri Flamberet Laks", "26 kr.", "Nigiri flamberet laks toppes med unagisauce, hvidløg og hvidløgsspirer"),
            new("Nigiri Crispy Ebi", "26 kr.", "Nigiri crispy ebi, toppes med chilimayo og sort masago", "skaldyr"),
        }
    );

    // ─── GUNKAN ──────────────────────────────────────────────────
    private MenuSection Gunkan() => new(
        Id: "gunkan",
        Title: "Gunkan",
        Images: new() { "/images/menu/gunkan1.jpg" },
        Subtitle: "Pr. stk.",
        Items: new()
        {
            new("Agurk med Ørredrogn", "29 kr.", "Gunkan med agurk og ørredrogn"),
            new("Agurk med Sort Masago", "29 kr.", "Gunkan med agurk og sort masago"),
            new("Agurk med Tuntartar", "29 kr.", "Gunkan med agurk og tuntartar"),
            new("Agurk med Krabbesalat", "29 kr.", "Gunkan med agurk og krabbesalat"),
        }
    );

    // ─── URA MAKI ────────────────────────────────────────────────
    private MenuSection UraMaki() => new(
        Id: "ura-maki",
        Title: "Ura Maki",
        Images: new() { "/images/menu/uramaki1.jpg" },
        Subtitle: "Alle Ura Maki fås i 8 skiver – 1 sushirulle skåret i 8 skiver",
        Items: new()
        {
            new("Ura Crispy Ebi", "89 kr.", "Tempurarejer, avokado, rullet i sort og hvid sesam toppet med unagisauce", "skaldyr, gluten", 1),
            new("Ura Crunchy Salmon", "89 kr.", "Laks, japansk radise, avokado, agurk rullet i orange masago, spicy sesam, toppet med chilimayonaise og crunchy risflagere", "gluten", 2),
            new("Ura Classic California", "89 kr.", "Surimi (krabbe), avokado, agurk rullet i sort og hvid sesam", "gluten", 3),
            new("Ura Red Alaskan", "89 kr.", "Laks, flødeost, avokado og agurk rullet i rød masago", "gluten, laktose", 4),
            new("Ura Simply Tuna", "89 kr.", "Tun, agurk, avokado, rullet i purløg og grøn masago toppet med chilimayo", "gluten", 5),
            new("Ura White Catch", "89 kr.", "Hamachi kingfish, flødeost, agurk, rullet i grøn masago, purløg og hvid sesam, toppet med krydret aioli og unagi", "gluten", 6),
            new("Ura Funky Tuna", "89 kr.", "Tuntartar, flødeost, agurk, mango, rullet i wasabi sesam", "laktose", 7),
            new("Ura Fresh Ebi", "89 kr.", "Kogt tigerreje, avokado, agurk, mango, rullet i wasabi sesam", "skaldyr", 8),
            new("Ura Chef's Special", "89 kr.", "Crispy Ebi, laks, avokado, flødeost og agurk, rullet i rød masago og sort/hvid sesam, toppet med chilimayo", "skaldyr, gluten, laktose", 9),
            new("Ura Crunchy Veggie", "89 kr.", "Avokado, tofu, agurk, japansk radise, rullet i spicy sesam – med eller uden flødeost"),
        }
    );

    // ─── KABURI MAKI ─────────────────────────────────────────────
    private MenuSection KaburiMaki() => new(
        Id: "kaburi-maki",
        Title: "Kaburi Maki",
        Images: new() { "/images/menu/kaburimaki1.jpg" },
        Subtitle: "Alle Kaburi Maki fås i 8 skiver – 1 sushirulle skåret i 8 skiver",
        Items: new()
        {
            new("Kaburi Royal Crunch", "119 kr.", "Crispy Ebi, flødeost, avokado rullet i rød masago, toppet med chilimayo, sprøde risflager og unagi", "skaldyr, gluten, laktose", 1),
            new("Kaburi Ebi Dream", "119 kr.", "Crispy Ebi, avokado toppet med laks, gingerdressing, kimchidrys og radiser", "skaldyr, gluten", 2),
            new("Kaburi Rainbow", "119 kr.", "Surimi (krabbe), agurk, toppet med avokado, laks, tun, tigerrejer, chilimayo og rødbedespirer", "gluten, skaldyr", 3),
            new("Kaburi Royal Green", "119 kr.", "Crispy Ebi, flødeost, toppet med avokado, unagisauce og kimchi sesam", "gluten, skaldyr, laktose", 4),
            new("Kaburi Devils Eye", "119 kr.", "Crispy Ebi, avokado toppet med tun, chilimayo, sriracha og chili", "skaldyr, gluten", 5),
            new("Kaburi Royal Flame", "120 kr.", "Tigerrejer, agurk toppet med flambegrillet laks, hvidløg, unagisauce og forårsløg", "gluten", 6),
            new("Kaburi Salmon Dream", "125 kr.", "Crispy ebi, avokado, agurk og hvidløg, toppet med flamberet laks, ørredrogn, unagi og chilimayo", "gluten, skaldyr", 7),
            new("Kaburi Flamed Tuna", "125 kr.", "Surimi, agurk, toppet med flamberet tun, chilimayo, sort masago drysset med purløg og kimchi drys", "gluten", 8),
            new("Kaburi Crabsalad", "125 kr.", "Avokado, agurk, tigerrejer, toppet med krabbesalat og purløg", "gluten, skaldyr", 9),
            new("Kaburi Tan's Special", "130 kr.", "Crispy ebi, flødeost, avokado, mango, citron, agurk, toppes med laks, hvidløg, sriracha, chilimayo, unagisauce, spicy sesam, purløg", "skaldyr, gluten, laktose", 10),
            new("Kaburi Red Lotus", "140 kr.", "Kogt tigerrejer, avokado, æble, mango, citron, agurk, toppes med flamberet laks, hvidløg, unagisauce, spicy sesam, hindbær og hvidløgsspirer", "skaldyr", 11),
            new("Kaburi Spicy Laksetartar", "135 kr.", "Crispy ebi, daikon, avokado. Rullet i spicy sesam og toppes med flamberet laksetartar, unagisauce, wasabicreme, sprøde panko krummer og purløg", "skaldyr, gluten", 12),
        }
    );

    // ─── HUSOMAKI CLASSIC ────────────────────────────────────────
    private MenuSection HusomaikiClassic() => new(
        Id: "husomaki-classic",
        Title: "Husomaki Classic",
        Images: new() { "/images/menu/husomakiclassic1.jpg" },
        Subtitle: "8 skiver – kan fås med chilimayo eller hvidløg",
        Items: new()
        {
            new("Huso Agurk", "40 kr.", "8 skiver husomaki med agurk", "", 1),
            new("Huso Avokado", "40 kr.", "8 skiver husomaki med avokado", "", 2),
            new("Huso Mango", "40 kr.", "8 skiver husomaki med mango", "", 3),
            new("Huso Japansk Radise", "40 kr.", "8 skiver husomaki med japansk radise", "", 4),
        }
    );

    // ─── HUSOMAKI UMI ────────────────────────────────────────────
    private MenuSection HusomaikiUmi() => new(
        Id: "husomaki-umi",
        Title: "Husomaki Umi",
        Subtitle: "8 skiver – kan fås med chilimayo eller hvidløg",
        Items: new()
        {
            new("Huso Laks", "45 kr.", "8 skiver husomaki med laks", "", 1),
            new("Huso Tigerrejer", "45 kr.", "8 skiver husomaki med tigerrejer", "skaldyr", 2),
            new("Huso Tun", "45 kr.", "8 skiver husomaki med tun", "", 3),
            new("Huso Surimi", "45 kr.", "8 skiver husomaki med surimi", "", 4),
            new("Huso Crispy Ebi", "45 kr.", "8 skiver husomaki med Crispy Ebi (reje)", "skaldyr", 5),
        }
    );

    // ─── FUTOMAKI ────────────────────────────────────────────────
    private MenuSection Futomaki() => new(
        Id: "futomaki",
        Title: "Futomaki",
        Subtitle: "6 skiver",
        Items: new()
        {
            new("Futo Salmon", "65 kr.", "Laks, flødeost, agurk, avokado, japansk radise", "", 1),
            new("Futo Tuna", "65 kr.", "Tun, chilimayo, salat, avokado og agurk", "", 2),
            new("Futo Crispy Ebi", "65 kr.", "Crispy ebi, salat, chilimayo og avokado", "skaldyr", 3),
            new("Futo Crispy Chicken", "70 kr.", "Crispy chicken, salat, chilimayo og avokado"),
            new("Futo California", "65 kr.", "Surimi, agurk og avokado", "", 5),
            new("Futo Vegan", "65 kr.", "Avokado, agurk, tofu og daikon salat – kan fås med flødeost", "", 6),
        }
    );

    // ─── NONE SUSHI RETTER ───────────────────────────────────────
    private MenuSection NoneSushiRetter() => new(
        Id: "none-sushi",
        Title: "None Sushi Retter",
        Subtitle: "Serveres med ris og tangsalat",
        Items: new()
        {
            new("Crispy Chicken med Ris og Tangsalat", "119 kr.", "Crispy chicken, toppet med unagisauce, purløg og sesam"),
            new("Crispy And med Ris og Tangsalat", "129 kr.", "Crispy and toppet med unagisauce, purløg og sesam"),
        }
    );

    // ─── RISPAPIR ────────────────────────────────────────────────
    private MenuSection Rispapir() => new(
        Id: "rispapir",
        Title: "Rispapir",
        Images: new() { "/images/menu/rispapir1.jpg" },
        Subtitle: "Rulle af rispapir med salatmix, avokado og agurk",
        Items: new()
        {
            new("Rispapir med Surimi og Gomasauce", "69 kr.", "Med surimi og gomasauce", "gluten", 1),
            new("Rispapir med Crispy Kylling", "69 kr.", "Med crispy kylling og chilimayo", "gluten", 2),
            new("Rispapir med Crispy Tempura", "69 kr.", "Med crispy tempura og chilimayo", "gluten, skaldyr", 3),
            new("Rispapir med And", "69 kr.", "Med and og sød hoisinmayo og peanuts", "nødder", 4),
            new("Rispapir med Tofu og Daikon", "69 kr.", "Med tofu og daikon, toppet med gomasauce og peanuts", "nødder", 5),
        }
    );

    // ─── MENUER ──────────────────────────────────────────────────
    private MenuSection Menuer() => new(
        Id: "menuer",
        Title: "Menuer",
        Subtitle: "Samlede menuer til én eller flere personer",
        Items: new()
        {
            new("Menu Solo Mix", "129 kr.", "12 stk. til 1 person.", "gluten, skaldyr, laktose",
                Contents: new() { "1× Nigiri laks", "1× Nigiri tun", "2× Ura Simply Tuna", "2× Ura Red Alaskan", "6× Futo Crispy Ebi" }),
            new("Menu Solo Maki", "129 kr.", "12 stk. til 1 person.", "",
                Contents: new() { "2× Ura Red Alaskan", "2× Ura Simply Tuna", "6× Futo California", "2× Kaburi Rainbow" }),
            new("Børnemenu", "89 kr.", "Til de mindste.", "",
                Contents: new() { "1× Fiskesticks", "1× Nigiri tigerreje", "1× Nigiri laks", "4× Huso laks", "4× Huso agurk" }),
            new("Menu MixMix", "259 kr.", "22 stk. til 1,5 person.", "",
                Contents: new() { "2× Nigiri laks", "2× Nigiri tun", "2× Nigiri hvidfisk", "4× Ura Simply Tuna", "4× Ura Red Alaskan", "6× Futo Crispy Ebi", "2× Kaburi Rainbow" }),
            new("Menu Green", "169 kr.", "16 stk. til 1 person – uden kød.", "",
                Contents: new() { "1× Tofulomme med tangsalat og sesam", "1× Gunkan med agurk og edamame", "8× Ura Veggie", "6× Futo Vegan" }),
            new("Menu Maki Deluxe", "349 kr.", "32 stk. til 2 personer.", "",
                Contents: new() { "4× Ura Simply Tuna", "4× Ura Red Alaskan", "8× Ura Crispy Ebi", "8× Kaburi Royal Green", "8× Kaburi Crabsalad" }),
            new("Menu Umi", "399 kr.", "36 stk. til 2 pers. – serveres med spiseligt bladguld af 24 ct. Pure Gold.", "",
                Contents: new() { "2× Nigiri laks", "2× Nigiri tun", "2× Nigiri hvidfisk", "4× Ura Red Alaskan", "4× Ura White Catch", "6× Rispapir surimi", "8× Ura Funky Tuna", "8× Kaburi Royal Crunch" }),
            new("Menu Royal Gold", "1.349 kr.",
                "72 stk. til 4 pers. – med rigtigt spiseligt bladguld af 24 ct. Pure Gold.", "",
                Contents: new()
                {
                    "1× Tangsalat", "1× Edamame med havsalt og lime",
                    "4× Nigiri laks", "4× Nigiri tun", "4× Nigiri hamachi",
                    "6× Futo California", "6× Rispapir and",
                    "8× Ura Red Alaskan", "8× Ura Funky Tuna", "8× Ura White Catch",
                    "8× Kaburi Crab Salad", "8× Kaburi Devils Eye",
                    "4× Valgfri sauce",
                    "8× Special Gold (Crispy Ebi, Tun, Avokado, toppet med flamberet hamachi og laks, pyntet med unagisauce, flødeost, ørredrogn og guldflager)"
                }),
        }
    );

    // ─── DIPS ────────────────────────────────────────────────────
    private MenuSection Dips() => new(
        Id: "dips",
        Title: "Dips / Dyppelse",
        Subtitle: "12 kr. pr. stk. eller 3 for 30 kr.",
        Items: new()
        {
            new("Chili Mayo", "12 kr.", ""),
            new("Goma Dressing", "12 kr.", ""),
            new("Unagi Sauce", "12 kr.", ""),
            new("Sød Hoisin Mayo", "12 kr.", ""),
            new("Ginger Sauce", "12 kr.", ""),
            new("Krydret Aioli", "12 kr.", ""),
            new("Sriracha Chili", "12 kr.", ""),
            new("Soya Mayo", "12 kr.", ""),
        }
    );

    // ─── DESSERT ─────────────────────────────────────────────────
    private MenuSection Dessert() => new(
        Id: "dessert",
        Title: "Dessert",
        Subtitle: "",
        Items: new()
        {
            new("Japansk Grøn The Is", "39 kr.", ""),
            new("Japansk Sesame Is", "39 kr.", ""),
            new("Bleeding Chokolate med Bær og Vanilje", "49 kr.", ""),
            new("Dagens Dessert", "", "Ring ind eller spørg vores tjener i restauranten"),
        }
    );

    // ─── DRIKKEKORT ──────────────────────────────────────────────
    private MenuSection Drikkekort() => new(
        Id: "drikkekort",
        Title: "Drikkekort",
        Images: new() { "/images/menu/drinks1.jpg" },
        Subtitle: "",
        Items: new()
        {
            new("Softdrink 25 cl.", "25 kr.", "Coca Cola, Coca Cola Zero, Sprite, Fanta"),
            new("Vand (1 glas isvand)", "15 kr.", ""),
            new("Vand (1 kande isvand)", "25 kr.", ""),
            new("Vand (1 kande agurkvand)", "35 kr.", ""),
            new("Iki Ginger Øl 33 cl.", "45 kr.", "Japansk øl"),
            new("Iki Greentea Øl 33 cl.", "45 kr.", "Japansk øl"),
            new("Asahi Black 33 cl.", "45 kr.", "Japansk øl"),
            new("Asahi Dry 33 cl.", "40 kr.", "Japansk øl"),
            new("Kirin Ichiban 33 cl.", "40 kr.", "Japansk øl"),
            new("Sapporo 33 cl.", "40 kr.", "Japansk øl"),
            new("Crabbies Ingefær Øl 33 cl.", "45 kr.", ""),
            new("Sake 180 mL", "89 kr.", ""),
            new("Grøn The ad libitum", "39 kr.", "Pr. person"),
            new("Matcha Latte", "45 kr.", ""),
            new("Stempel Kaffe", "59 kr.", "Pr. kande"),
            new("Japansk Blommevin (Ume)", "55 kr.", "Blandes op med danskvand"),
        }
    );
}
