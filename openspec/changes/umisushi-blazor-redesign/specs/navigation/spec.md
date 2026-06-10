## ADDED Requirements

### Requirement: Responsiv navigationsbar vises på alle sider
Systemet SHALL vise en navigationsbar øverst på alle sider med logo til venstre og links til: Hjem, Menu, Reservation, Bestil Take-Away, Kontakt.

#### Scenario: Alle navlinks er synlige på desktop
- **WHEN** en side indlæses på desktop (≥768px)
- **THEN** vises alle navigationslinks horisontalt i navbaren

### Requirement: Hamburger-menu på mobil
Systemet SHALL vise en hamburger-ikonknap på mobilenheder (< 768px) der toggler en dropdown-menu med alle navigationslinks.

#### Scenario: Hamburger-menu åbner på mobil
- **WHEN** brugeren klikker hamburger-ikonet på mobil
- **THEN** vises en dropdown med alle navigationslinks

#### Scenario: Hamburger-menu lukker ved valg
- **WHEN** brugeren klikker et navigationslink i hamburger-menuen
- **THEN** lukkes menuen og brugeren navigeres til den valgte side

### Requirement: Aktiv navigationslink markeres
Systemet SHALL markere den aktuelt aktive side i navigationsbaren visuelt (f.eks. underline eller farveændring).

#### Scenario: Aktiv side markeres
- **WHEN** brugeren er på `/menu`
- **THEN** er Menu-linket i navbaren markeret som aktivt

### Requirement: "Book et bord"-CTA-knap i navbaren
Systemet SHALL vise en fremhævet CTA-knap i navbaren med teksten "Book et bord" der linker til `/reservation`.

#### Scenario: Book et bord-knap er synlig
- **WHEN** alle sider indlæses
- **THEN** er "Book et bord"-knappen synlig i navbaren med distinkt styling

### Requirement: Footer vises på alle sider
Systemet SHALL vise en footer med: logo, navigationslinks, åbningstider (kompakt), kontaktinfo (telefon + e-mail), Facebook-link og copyright-tekst.

#### Scenario: Footer indeholder al nødvendig info
- **WHEN** en side er scrollet til bunden
- **THEN** vises footer med logo, links, åbningstider og kontaktinfo

### Requirement: Facebook-link er i footer
Systemet SHALL vise et link til facebook.com/umisushidk i footeren med Facebook-ikon.

#### Scenario: Facebook-link åbner eksternt
- **WHEN** brugeren klikker Facebook-linket i footeren
- **THEN** åbnes facebook.com/umisushidk i nyt faneblad
