## Why

UmiSushi i Ry har en forældet hjemmeside der ikke afspejler restaurantens høje kvalitet og unikke oplevelse. En moderne Blazor-webapp vil give en langt bedre brugeroplevelse, øge online synlighed via SEO og øge konverteringer til reservationer og take-away bestillinger.

## What Changes

- Komplet genopbygning af frontend som Blazor WebAssembly / Server webapp
- Dansk-sproget interface (primærsprog: da-DK)
- SEO-optimeret struktur med strukturerede data (Schema.org Restaurant/Menu), metatags og semantic HTML
- Moderne, visuelt stærkt design der matcher en premium sushi-restaurant
- Interaktivt menukort med kategorier, allergen-filter og priser
- Online reservation via embedded formular
- Take-away bestillings-integration (link/embed til eksisterende weorder.xyz)
- Mobiloptimeret responsive layout
- Kontaktside med kort (Google Maps embed), åbningstider og kontaktformular
- Nytårsmenu og sæsonmenuer som separate sider
- Performance: statisk pre-rendering, lazy loading, optimerede billeder

## Capabilities

### New Capabilities

- `homepage`: Landing page med hero, intro-tekst, highlights og CTA'er til reservation og take-away
- `menu-page`: Komplet interaktivt menukort organiseret i kategorier med allergen-info og priser
- `reservation-page`: Reservationsside med formular/embed og kontaktinfo
- `takeaway-page`: Take-away side med link/embed til bestillingssystem
- `contact-page`: Kontaktside med åbningstider, kort og kontaktformular
- `seo-foundation`: Metatags, Open Graph, strukturerede data (Schema.org), sitemap.xml, robots.txt
- `navigation`: Responsiv navigationsbar og footer med alle links og sociale medier
- `seasonal-menu`: Nytårsmenu og sæsonspecifikke tilbud som dedikerede undersider

### Modified Capabilities

## Impact

- **Kode**: Ny Blazor-webapp (ny kodebase under `src/`)
- **Afhængigheder**: .NET 8+ / Blazor, MudBlazor eller Tailwind CSS, System.Text.Json
- **SEO**: canonical URL'er, hreflang da-DK, structured data for restaurant og menu
- **Hosting**: Kompatibel med Azure Static Web Apps, GitHub Pages (WASM) eller Blazor Server
- **Ekstern integration**: weorder.xyz (take-away), Google Maps embed, TripAdvisor-link, Facebook
