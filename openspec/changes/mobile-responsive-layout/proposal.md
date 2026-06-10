## Why

On mobile screens several sections overflow horizontally — most visibly the "Find os på sociale medier" card row, which stays locked at three columns and pushes content past the viewport edge, causing a horizontal scrollbar and clipped text. The site needs to be reliably responsive and mobile-friendly across all pages.

## What Changes

- Replace inline, hard-coded grid layouts (e.g. `style="display:grid;grid-template-columns:repeat(3,1fr)"`) with reusable CSS utility classes so that stylesheet media queries can actually collapse them on small screens.
- Make the social-media card row, the opening-hours two-column layout, and the intro two-column layout stack vertically on mobile.
- Add a global horizontal-overflow guard (`overflow-x` clipping and `max-width:100%` on media/embeds) so no element can push the page wider than the viewport.
- Audit remaining pages (Menu, Contact, Reservation, Take-Away, Seasonal) for the same inline-grid pattern and convert them to responsive utility classes.
- Verify layouts at common mobile widths (320–430px) and at the tablet breakpoint.

## Capabilities

### New Capabilities
- `responsive-layout`: Defines the responsive behaviour the site must guarantee — no horizontal overflow on mobile, multi-column sections collapsing to a single column below defined breakpoints, and fluid media that never exceeds the viewport.

### Modified Capabilities
<!-- None: no existing spec requirements change. -->

## Impact

- `src/UmiSushi.Web/wwwroot/css/app.css` — new layout utility classes and a global overflow guard.
- `src/UmiSushi.Web/Pages/Home.razor` — replace inline grid styles with utility classes (social-media row, opening-hours, intro columns).
- Other page components reusing the inline-grid pattern (`Menu.razor`, `Contact.razor`, `Reservation.razor`, `TakeAway.razor`, `SeasonalMenu.razor`) as found during the audit.
- No data, API, or dependency changes — CSS/markup only.
