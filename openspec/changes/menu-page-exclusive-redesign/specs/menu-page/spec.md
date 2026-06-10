## MODIFIED Requirements

### Requirement: Menuen er mobiloptimeret
Systemet SHALL præsentere menukortet i et layout der er nemt at læse og navigere på mobilenheder med tommelfingernavigation. Sektionsbilleder SHALL skjules på skærme under 768px. Items vises altid i enkeltkolonne på mobil.

#### Scenario: Menuen er brugbar på mobil
- **WHEN** menusiden vises på en skærm under 480px bred
- **THEN** vises kategorierne som scrollbar horizontal tab-bar og menupunkterne i enkeltkolonne-layout

#### Scenario: Billeder skjules på mobil
- **WHEN** menusiden vises på en skærm under 768px
- **THEN** er sektionsbilleder ikke synlige og optager ingen plads i layoutet
