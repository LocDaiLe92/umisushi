## ADDED Requirements

### Requirement: Menuen vises opdelt i kategorier
Systemet SHALL vise menukortet opdelt i følgende kategorier som navigerbare faner eller ankerpunkter: Forretter, Sashimi Menuer, Sashimi, Nigiri Classics, Nigiri Deluxe, Gunkan, Maki, Ura Maki, Kaburi Maki, Husomaki Classic, Husomaki Umi, Futomaki, None Sushi Retter, Rispapir, Menuer, Dips, Dessert, Drikkekort.

#### Scenario: Kategorinavigation fremhæver aktiv kategori
- **WHEN** brugeren klikker på en kategorifane
- **THEN** scrolles til den tilsvarende menusektion og fanen markeres som aktiv

### Requirement: Hver menuvare viser navn, pris og beskrivelse
Systemet SHALL vise hvert menupunkt med: nummer (hvis relevant), navn, pris i DKK og ingrediensbeskrivelse.

#### Scenario: Menuvare er korrekt formateret
- **WHEN** menusiden er indlæst
- **THEN** vises alle menupunkter med korrekt navn, pris og beskrivelse

### Requirement: Allergeninformation vises per menuvare
Systemet SHALL vise allergener for relevante menupunkter i parentes (f.eks. skaldyr, gluten, laktose). En note SHALL informere brugeren om at henvende sig til personalet ved spørgsmål om allergener.

#### Scenario: Allergener fremgår af menupunkt
- **WHEN** et menupunkt har allergener
- **THEN** vises allergenerne i parentes efter ingrediensbeskrivelsen

#### Scenario: Allergennote er synlig
- **WHEN** menusiden indlæses
- **THEN** vises en generel note om allergenhenvendelse til personalet

### Requirement: Menuen er mobiloptimeret
Systemet SHALL præsentere menukortet i et layout der er nemt at læse og navigere på mobilenheder med tommelfingernavigation.

#### Scenario: Menuen er brugbar på mobil
- **WHEN** menusiden vises på en skærm under 480px bred
- **THEN** vises kategorierne som scrollbar horizontal tab-bar og menupunkterne i enkeltkolonne-layout

### Requirement: Sticky kategoribar
Systemet SHALL fastholde kategorinavigationen øverst på siden under scroll, så brugeren altid kan skifte kategori.

#### Scenario: Kategoribar følger scroll
- **WHEN** brugeren scroller ned på menusiden
- **THEN** forbliver kategoribaren synlig øverst i viewporten

### Requirement: Menuer (samlede pakker) vises med indhold
Systemet SHALL vise samlede menu-pakker (Solo Mix, MixMix, Green, Maki Deluxe, UMI, Royal Gold m.fl.) med komplet indhold og samlet pris.

#### Scenario: Menupakke viser fuldt indhold
- **WHEN** brugeren kigger på en menupakke
- **THEN** vises alle inkluderede retter, antal stykker og samlet pris
