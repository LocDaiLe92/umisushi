## ADDED Requirements

### Requirement: Menu items visas i to kolonner på desktop
Systemet SHALL vise menupunkter i et to-kolonne layout på skærme ≥768px for sektioner med 6 eller flere items. Sektioner med færre end 6 items vises i enkeltkolonne.

#### Scenario: To-kolonne layout aktiveres på desktop
- **WHEN** menusiden vises på en skærm ≥768px og en sektion har ≥6 items
- **THEN** vises menupunkterne i to lige brede kolonner ved hjælp af CSS multi-column

#### Scenario: Enkeltkolonne fallback for korte sektioner
- **WHEN** en sektion har færre end 6 items
- **THEN** vises punkterne i én kolonne uanset skærmbredde

#### Scenario: Mobilvisning er enkeltkolonne
- **WHEN** menusiden vises på en skærm under 768px
- **THEN** vises alle menupunkter i enkeltkolonne

---

### Requirement: Sektionsbillede flyder ved siden af itemlisten
Systemet SHALL vise sektionsbilledet som et floated element til højre for itemlisten, så tekst og items omslutter billedet naturligt. Billedet SHALL have afrundede hjørner og en blød skygge.

#### Scenario: Billede vises til højre for items
- **WHEN** en menusektion har et tilknyttet billede og vises på desktop (≥768px)
- **THEN** vises billedet float:right ved siden af itemlisten, ikke som en banner

#### Scenario: Billede vises ikke på mobil
- **WHEN** menusiden vises på skærm under 768px
- **THEN** vises sektionsbilledet ikke (skjult) for at spare plads

#### Scenario: Sektioner uden billede er upåvirkede
- **WHEN** en sektion ikke har et billede
- **THEN** vises kun overskrift og items i normal layout

---

### Requirement: Menupunktrækker har klassisk dotted leader linje
Systemet SHALL vise hvert menupunkt med navn til venstre, en stiplet prikkelinje (leader line) og pris til højre — som i et trykt menukort.

#### Scenario: Leader line vises mellem navn og pris
- **WHEN** et menupunkt med pris vises
- **THEN** er der en dotted/stiplet linje der strækker sig fra navn til pris i samme række

#### Scenario: Menupunkter uden pris har ingen leader line
- **WHEN** et menupunkt ikke har en pris
- **THEN** vises ingen prikkelinje

---

### Requirement: Sektionsoverskrifter har dekorativ behandling
Systemet SHALL vise sektionsoverskrifter med serif-skrifttype, generøs øvre margen og en dekorativ understregning/accent i brandfarven.

#### Scenario: Sektionsoverskrift fremstår distinkt
- **WHEN** en menusektion indlæses
- **THEN** vises titlen med serif-skrifttype, rød accent og tydelig adskillelse fra foregående sektion

---

### Requirement: Menusiden har varm cream baggrund
Systemet SHALL vise menuindholdsområdet med en varm off-white/cream baggrundsfarve (#faf8f4) for at give et premium "trykt menukort" udtryk.

#### Scenario: Cream baggrund er synlig bag menuindhold
- **WHEN** brugeren besøger menusiden
- **THEN** er baggrunden i indholdsområdet varm cream, ikke hvid
