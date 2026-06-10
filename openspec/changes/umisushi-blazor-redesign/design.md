## Context

UmiSushi er en sushi-restaurant i Ry, Danmark. Den nuværende hjemmeside er bygget på et generisk CMS og fremstår forældet, langsom og dårligt optimeret til mobilenheder og søgemaskiner. Restauranten har et komplet menukort (forretter, sashimi, nigiri, maki, menuer, drikkevarer, dessert) og tilbyder bordreservation, dine-in og take-away. Projektet er en greenfield Blazor-webapp der erstatter den eksisterende hjemmeside fuldstændigt.

## Goals / Non-Goals

**Goals:**
- Visually premium Blazor-webapp der kommunikerer kvalitet og autenticitet
- Fuldt dansksproget UI (da-DK locale)
- SEO-first: strukturerede data, metatags, sitemap, semantisk HTML5
- Interaktivt menukort med kategorier, priser og allergeninfo
- Responsivt, mobiloptimeret design
- Hurtig initial page load via statisk pre-rendering
- Reservation og take-away integration
- Tilgængelighed (WCAG 2.1 AA)

**Non-Goals:**
- Backoffice / CMS til menuadministration (menuen hardkodes initialt)
- Online betaling
- Loyalitetsprogram
- Brugerkonto / login
- Flersproget support (kun dansk)

## Decisions

### D1: Blazor WebAssembly med statisk pre-rendering
**Valg**: Blazor WebAssembly hosted app med statisk pre-rendering (SSG via .NET 8 static web assets).  
**Rationale**: Giver bedste SEO (HTML serveres pre-renderet til crawlere), hurtig TTFB og mulighed for hosting på Azure Static Web Apps eller GitHub Pages uden server-runtime.  
**Alternativ**: Blazor Server – kræver aktiv server, dyrere at hoste og dårligere latency for DK-brugere udenfor Azure-region.  
**Alternativ**: Next.js/React – udenfor tech-stack krav (Blazor specifikt ønsket).

### D2: CSS-framework – Tailwind CSS via CDN + custom CSS
**Valg**: Tailwind CSS (CDN build) + et lille custom CSS-lag til brand-specifikke tokens.  
**Rationale**: Tailwind giver hurtig iteration, utility-first klasser, built-in responsive utilities og ingen runtime. Undgår MudBlazor (for component-heavy, svær at tilpasse visuelt).  
**Alternativ**: MudBlazor – god komponent-bibliotek men begrænset designfrihed; komponenter føles "Material Design", ikke premium sushi-æstetik.

### D3: Designretning – Mørkt tema med accent i varm guld/koral
**Valg**: Primær baggrund `#0D0D0D` / `#111111`, sekundær `#1A1A1A`. Accent: varm guld `#C9A96E` og koral/rød `#E05C4B`. Typografi: `Playfair Display` (serif, headings) + `Inter` (sans, body).  
**Rationale**: Mørkt tema signalerer premium/eksklusivitet (f.eks. Nobu, Matsuhisa). Guld-accent er ikonisk for japansk gastronomi. Serif heading font giver elegance uden at virke gammelmodigt.  
**Alternativ**: Hvid/lys tema med sort tekst – virker mere casual, matcher ikke "premium sushi" perception.

### D4: Menudata som statisk C# model
**Valg**: Menudata defineres i en `MenuDataService.cs` som en statisk in-memory C# record-struktur.  
**Rationale**: Ingen database-overhead, hurtig deployment, nem at opdatere via kodeændring. Menustrukturen er stabil og ændres sjældent.  
**Alternativ**: JSON-fil i wwwroot – fungerer, men mister type-safety og refactoring-support.  
**Alternativ**: Headless CMS (Contentful, Sanity) – over-engineered for en enkelt restaurant.

### D5: SEO – Schema.org strukturerede data inline som JSON-LD
**Valg**: `<script type="application/ld+json">` med `Restaurant` og `Menu`/`MenuItem` Schema.org typer injiceret i `<head>` via Blazor `HeadContent`.  
**Rationale**: Google bruger JSON-LD til rich results (restaurantinfo, åbningstider). Inline JSON-LD er nemmest at opdatere og crawl-effektivt.

### D6: Routing
**Valg**: Blazor built-in routing med `/`, `/menu`, `/reservation`, `/bestil-take-away`, `/kontakt`, `/nytarsmenu`.  
**Rationale**: Matcher eksisterende URL-struktur tæt for at bevare eventuelle eksisterende backlinks.

## Risks / Trade-offs

- **[Risk] Blazor WASM initial bundle size (~5-10 MB)** → Mitigation: Lazy loading af non-critical assemblies; aggressiv Brotli-komprimering; CDN til statiske assets. Kritiske sider pre-renderes som statisk HTML.
- **[Risk] SEO for SPA** → Mitigation: Statisk pre-rendering via `dotnet publish` med Blazor static generation; alle sider genereres som `.html`-filer.
- **[Risk] Menudata bliver forældet** → Mitigation: Klar kommentar i `MenuDataService.cs` med ansvarlig person og instruktion. Tilføj TODO om fremtidig JSON/CMS-migration.
- **[Risk] Weorder.xyz take-away integration ændrer sig** → Mitigation: Take-away siden bruger en konfigurérbar URL-konstant, nem at opdatere.

## Migration Plan

1. Byg Blazor-app i `src/UmiSushi.Web/`
2. Deploy til Azure Static Web Apps (eller Netlify) på staging-URL
3. Klient-test på mobil/desktop, SEO-audit med Lighthouse
4. Skift DNS til ny app
5. Tilføj 301-redirects for eksisterende URL'er der ændrer sig

## Open Questions

- Skal reservation-formularen sende e-mail direkte (SMTP/SendGrid) eller blot linke til eksisterende system?
- Ønskes Google Analytics / Matomo tracking?
- Er der billeder/fotografi til rådighed, eller skal placeholder-billeder bruges?
- Skal nytårsmenuen have en separat deadline/udløbsdato der gemmer siden?
