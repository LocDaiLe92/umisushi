## ADDED Requirements

### Requirement: Hver side har unikke metatags
Systemet SHALL injicere unikke `<title>` og `<meta name="description">` tags på hver side via Blazor `HeadContent`. Titler SHALL følge mønsteret: `[Sidenavn] – UmiSushi Ry`.

#### Scenario: Hjemmeside metatags er korrekte
- **WHEN** forsiden indlæses
- **THEN** er `<title>` "UmiSushi Ry – Autentisk Sushi i Hjertet af Ry" og description beskriver restauranten på dansk

#### Scenario: Menusidens metatags er unikke
- **WHEN** menusiden indlæses
- **THEN** er titlen "Menu – UmiSushi Ry" og description beskriver menukortet

### Requirement: Open Graph tags er implementeret
Systemet SHALL inkludere `og:title`, `og:description`, `og:image` og `og:url` tags på alle primære sider.

#### Scenario: Open Graph tags er til stede
- **WHEN** en side's HTML-kilde inspiceres
- **THEN** er alle fire OG-tags til stede med relevante værdier

### Requirement: Schema.org Restaurant-strukturerede data injiceres på forsiden
Systemet SHALL inkludere et `<script type="application/ld+json">` JSON-LD blok på forsiden med `@type: "Restaurant"` inkl. navn, adresse, telefon, åbningstider, servesCuisine og URL.

#### Scenario: Restaurant JSON-LD er korrekt
- **WHEN** forsidens HTML-kilde inspiceres
- **THEN** er et gyldigt JSON-LD Restaurant-objekt til stede med alle relevante felter

### Requirement: Schema.org Menu strukturerede data injiceres på menusiden
Systemet SHALL inkludere JSON-LD med `@type: "Menu"` og repræsentative `MenuItem`-objekter på menusiden.

#### Scenario: Menu JSON-LD er til stede
- **WHEN** menuside HTML-kilde inspiceres
- **THEN** er et gyldigt JSON-LD Menu-objekt til stede

### Requirement: sitemap.xml genereres
Systemet SHALL generere en statisk `sitemap.xml` der indeholder alle primære URL'er: `/`, `/menu`, `/reservation`, `/bestil-take-away`, `/kontakt`, `/nytarsmenu`.

#### Scenario: sitemap.xml er tilgængeligt
- **WHEN** `/sitemap.xml` tilgås
- **THEN** returneres et gyldigt XML-sitemap med alle sider

### Requirement: robots.txt er konfigureret korrekt
Systemet SHALL inkludere en `robots.txt` der tillader alle crawlere og peger på sitemap.

#### Scenario: robots.txt er korrekt
- **WHEN** `/robots.txt` tilgås
- **THEN** returneres en robots.txt med `User-agent: *`, `Allow: /` og `Sitemap:` direktiv

### Requirement: Canonical URL-tags er på alle sider
Systemet SHALL inkludere `<link rel="canonical">` på alle sider.

#### Scenario: Canonical tag er til stede
- **WHEN** en sides HTML inspiceres
- **THEN** er `<link rel="canonical" href="...">` til stede med sidens absolutte URL

### Requirement: lang-attribut er sat korrekt
Systemet SHALL sætte `<html lang="da">` på alle sider.

#### Scenario: lang-attribut er korrekt
- **WHEN** HTML-kilden inspiceres
- **THEN** er `<html lang="da">` til stede
