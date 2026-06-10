## ADDED Requirements

### Requirement: Nytårsmenu-side viser sæsonmenu
Systemet SHALL vise en dedikeret side på `/nytarsmenu` med nytårsmenuen for den aktuelle sæson (2025/2026) inkl. retter og pris.

#### Scenario: Nytårsmenu-siden er tilgængelig
- **WHEN** brugeren navigerer til `/nytarsmenu`
- **THEN** vises nytårsmenu med indhold og pris

### Requirement: Sæsonmenu linkes fra navigationen
Systemet SHALL inkludere et link til nytårsmenuen i footer-navigation og evt. i navbaren som ekstra punkt.

#### Scenario: Nytårsmenu-link er synligt
- **WHEN** nytårsmenuen er aktiv sæson
- **THEN** vises et link til `/nytarsmenu` i footer-navigationslinkene

### Requirement: Sæsonmenu har visuel markering som special
Systemet SHALL differentiere sæsonmenu-siden visuelt fra det ordinære menukort med et "Sæson Special" eller tilsvarende badge.

#### Scenario: Sæson-badge vises
- **WHEN** nytårsmenu-siden indlæses
- **THEN** vises et visuelt distinkt badge eller banner der markerer indholdet som sæsonspecielt
