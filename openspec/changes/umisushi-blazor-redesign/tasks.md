## 1. Projekt Scaffold

- [ ] 1.1 Opret Blazor WebAssembly hosted app: `dotnet new blazorwasm -o src/UmiSushi.Web --hosted`
- [ ] 1.2 Tilføj Tailwind CSS via CDN i `wwwroot/index.html` og konfigurer Tailwind config
- [ ] 1.3 Opret `appsettings.json` / konstanter-fil med konfigurerbare værdier: TakeawayUrl, FacebookUrl, TripAdvisorUrl, GoogleMapsEmbedUrl, Phone, Email
- [ ] 1.4 Konfigurer `<html lang="da">` i `wwwroot/index.html`
- [ ] 1.5 Tilføj Google Fonts: Playfair Display + Inter via `<link>` i `index.html`
- [ ] 1.6 Opret global CSS custom properties (farvetokens, spacing, font-stacks) i `wwwroot/css/app.css`
- [ ] 1.7 Konfigurer routing i `App.razor` med alle primære ruter: `/`, `/menu`, `/reservation`, `/bestil-take-away`, `/kontakt`, `/nytarsmenu`

## 2. Design System & Shared Komponenter

- [ ] 2.1 Opret `Components/Layout/MainLayout.razor` med NavBar + Footer + `<main>` slot
- [ ] 2.2 Byg `Components/Layout/NavBar.razor`: logo, desktop-links, "Book et bord"-CTA-knap, hamburger-toggle
- [ ] 2.3 Implementer hamburger-menu toggle-logik i `NavBar.razor` med CSS transition
- [ ] 2.4 Implementer aktiv-link markering i NavBar via `NavigationManager.Uri`
- [ ] 2.5 Byg `Components/Layout/Footer.razor`: logo, links, åbningstider (kompakt), kontaktinfo, Facebook-ikon-link, copyright
- [ ] 2.6 Opret `Components/Shared/SectionHeading.razor` – genbrugelig sektion-overskrift komponent
- [ ] 2.7 Opret `Components/Shared/CtaButton.razor` – genbrugelig CTA-knap med primær/sekundær variant

## 3. Data Layer

- [ ] 3.1 Opret `Services/MenuDataService.cs` med alle menukategorier som statiske C# records/klasser
- [ ] 3.2 Implementer `MenuCategory`, `MenuItem`, `MenuSection` modeller i `Models/Menu/`
- [ ] 3.3 Populer forretter: Crispy Ebi, Crispy N' Spice Chicken, Flamberet Laks, Misosuppe, Tangsalat, Edamamebønner, Spicy Edamame, Gyoza
- [ ] 3.4 Populer sashimi-sektioner: Sashimi Menuer (12 stk / Deluxe 16 stk), individuel sashimi (laks, tun, hamachi)
- [ ] 3.5 Populer nigiri: Classics 2 stk (laks, tun, avokado, daikon, mango, tigerrejer) + Deluxe (hvidfisk, sød ebi, flamberet laks, crispy ebi)
- [ ] 3.6 Populer gunkan (agurk varianter), alle Maki-kategorier
- [ ] 3.7 Populer Ura Maki (alle 10 varianter), Kaburi Maki (alle 12 + special editions)
- [ ] 3.8 Populer Husomaki Classic + Umi (alle varianter), Futomaki (alle 6 varianter)
- [ ] 3.9 Populer None Sushi Retter, Rispapir (alle 5 varianter)
- [ ] 3.10 Populer Menuer: Solo Mix, Solo Maki, Børnemenu, MixMix, Green, Maki Deluxe, UMI 36 stk, Royal Gold 72 stk
- [ ] 3.11 Populer Dips/Dyppelse, Dessert, Drikkekort (softdrinks, vand, japanske øl, ingefær øl, sake, te/kaffe, blommevin)
- [ ] 3.12 Registrer `MenuDataService` som singleton i `Program.cs` DI-container
- [ ] 3.13 Opret `Services/SiteConfig.cs` med statiske konfigurationsværdier (telefon, e-mail, adresse, URLs)

## 4. Forside (Homepage)

- [ ] 4.1 Opret `Pages/Home.razor` med `@page "/"` og korrekte metatags via `<PageTitle>` + `HeadContent`
- [ ] 4.2 Implementer fuldskærms hero-sektion: baggrundsbillede med mørkt overlay, logo/titel, tagline, "Book et bord" + "Se menuen" CTA
- [ ] 4.3 Implementer om-restauranten sektion med tekst og stemningsbillede
- [ ] 4.4 Implementer 3-highlights grid (Frisk sushi / Hyggelig atmosfære / Take-away)
- [ ] 4.5 Implementer åbningstider-sektion på forsiden (kompakt tabel)
- [ ] 4.6 Implementer take-away CTA-sektion med knap der åbner weorder.xyz i nyt faneblad
- [ ] 4.7 Tilføj TripAdvisor-anmeldelselink med "Se hvad gæsterne siger om os"
- [ ] 4.8 Tilføj Schema.org Restaurant JSON-LD i `<HeadContent>` med alle relevante felter

## 5. Menukort (Menu Page)

- [ ] 5.1 Opret `Pages/Menu.razor` med `@page "/menu"`, metatags og Schema.org Menu JSON-LD
- [ ] 5.2 Byg `Components/Menu/CategoryTabBar.razor` – horisontal scrollbar tab-bar der highlighter aktiv kategori og scrollar til sektion
- [ ] 5.3 Implementer sticky kategoribar ved scroll (CSS `position: sticky; top: NavbarHeight`)
- [ ] 5.4 Byg `Components/Menu/MenuSection.razor` – viser én menukategori med overskrift og liste af varer
- [ ] 5.5 Byg `Components/Menu/MenuItemCard.razor` – viser navn, pris, beskrivelse, allergener for ét menupunkt
- [ ] 5.6 Rendér alle menudata via `MenuDataService` i `Menu.razor`
- [ ] 5.7 Implementer allergen-visning: allergener i parentes + generel allergen-note øverst i forretter-sektionen
- [ ] 5.8 Test mobilvisning: enkeltkolonne-layout + horisontal tab-scroll

## 6. Reservation Side

- [ ] 6.1 Opret `Pages/Reservation.razor` med `@page "/reservation"` og korrekte metatags
- [ ] 6.2 Vis kontaktinfo (telefon + e-mail) som primær reservationsmetode med klikbare links
- [ ] 6.3 Byg `Components/Reservation/ReservationForm.razor` med felter: Navn, Telefon/email, Dato, Antal personer, Særlige ønsker
- [ ] 6.4 Implementer client-side Blazor formularvalidering med `EditForm` og `DataAnnotationsValidator`
- [ ] 6.5 Implementer `OnValidSubmit` handler der viser bekræftelsesbesked (mailto-fallback eller console.log til videre implementering)
- [ ] 6.6 Vis åbningstider på reservationssiden som kontekst

## 7. Take-Away Side

- [ ] 7.1 Opret `Pages/TakeAway.razor` med `@page "/bestil-take-away"` og korrekte metatags
- [ ] 7.2 Vis prominerende "Bestil nu"-CTA der åbner `SiteConfig.TakeawayUrl` i nyt faneblad
- [ ] 7.3 Vis kort beskrivelse af take-away-processen og afhentningsadresse

## 8. Kontakt Side

- [ ] 8.1 Opret `Pages/Contact.razor` med `@page "/kontakt"` og korrekte metatags
- [ ] 8.2 Vis adresse, klikbart telefonnummer og klikbar e-mail
- [ ] 8.3 Embed Google Maps iframe med restaurantens placering i Ry
- [ ] 8.4 Vis komplet åbningstidstabel inkl. lukkedage og køkkentid-note
- [ ] 8.5 Tilføj Findsmiley-badge/link til findsmiley.dk/635610

## 9. Sæsonmenu Side

- [ ] 9.1 Opret `Pages/SeasonalMenu.razor` med `@page "/nytarsmenu"` og korrekte metatags
- [ ] 9.2 Vis Nytårsmenu 2025/2026 med indhold og pris
- [ ] 9.3 Tilføj visuelt "Sæson Special"-badge/banner
- [ ] 9.4 Tilføj link til `/nytarsmenu` i Footer-navigation

## 10. SEO Foundation

- [ ] 10.1 Implementer `Components/Seo/SeoHead.razor` komponent til genbrugelige metatag-parametre (title, description, canonical, og og-tags)
- [ ] 10.2 Brug `SeoHead` på alle 6 primære sider med unikke værdier
- [ ] 10.3 Generer statisk `wwwroot/sitemap.xml` med alle primære URL'er
- [ ] 10.4 Tilføj `wwwroot/robots.txt` med `Allow: /` og Sitemap-direktiv
- [ ] 10.5 Verificer `<html lang="da">` er sat i `index.html`
- [ ] 10.6 Tilføj Open Graph tags (`og:title`, `og:description`, `og:image`, `og:url`) på alle primære sider

## 11. Billeder & Assets

- [ ] 11.1 Tilføj placeholder hero-billede (høj kvalitet sushi billede) i `wwwroot/images/hero.jpg`
- [ ] 11.2 Tilføj UmiSushi logo (SVG/PNG) i `wwwroot/images/logo.svg`
- [ ] 11.3 Tilføj OG-image (1200x630) til Open Graph i `wwwroot/images/og-image.jpg`
- [ ] 11.4 Konfigurer lazy loading på alle `<img>` tags (`loading="lazy"`)

## 12. Kvalitetssikring & Deploy

- [ ] 12.1 Kør Lighthouse audit på alle 6 primære sider: mål ≥90 Performance, ≥90 SEO, ≥90 Accessibility
- [ ] 12.2 Test på mobilenheder: iPhone Safari, Android Chrome
- [ ] 12.3 Verificer alle interne links navigerer korrekt
- [ ] 12.4 Verificer alle eksterne links åbner i nyt faneblad (`target="_blank" rel="noopener noreferrer"`)
- [ ] 12.5 Kør `dotnet publish` og verificer statisk output under `publish/wwwroot/`
- [ ] 12.6 Test sitemap.xml og robots.txt er tilgængelige i build output
- [ ] 12.7 Valider Schema.org JSON-LD med Google Rich Results Test
