## Context

The UmiSushi site is a Blazor WebAssembly app styled with a single global stylesheet (`wwwroot/css/app.css`) plus inline `style` attributes in the Razor pages. Several sections set their grid layout inline, e.g. the social-media row in `Home.razor`:

```razor
<div style="display:grid;grid-template-columns:repeat(3,1fr);gap:1.5rem;">
```

The stylesheet already contains a mobile rule intended to fix this:

```css
@media (max-width: 768px) { .some-card { grid-column: span 1; } }
```

But this targets the card, not the grid container. The container's column count is an **inline style**, which has higher specificity than any stylesheet rule and cannot be overridden by a media query. As a result the row stays at three columns on mobile, squeezing each card until its content spills past the viewport and triggers horizontal scroll. The same inline-grid pattern is used for the opening-hours and intro two-column sections.

## Goals / Non-Goals

**Goals:**
- Eliminate horizontal overflow on mobile across all pages.
- Make multi-column sections collapse to one column at the mobile breakpoint.
- Move responsive column control out of inline styles into reusable CSS classes.
- Add a defensive global guard so future inline mistakes cannot break the viewport.

**Non-Goals:**
- No visual redesign, color, typography, or content changes.
- No CSS framework introduction (stay with the existing hand-written stylesheet).
- No changes to data, services, routing, or business logic.

## Decisions

**Decision: Replace inline grids with named utility classes.**
Introduce small layout classes in `app.css` (e.g. `.some-grid` for the social row, `.two-col` for two-column sections) that declare the desktop column layout and collapse to a single column inside the existing breakpoints. Replace the inline `style="display:grid;..."` attributes in the Razor markup with these classes.
*Why over alternatives:* Adding `!important` to the existing card rule would not help because the container — not the card — holds the column count. Keeping inline styles and toggling via JS would be fragile. Class-driven layout is the standard, centralized, media-query-friendly approach.

**Decision: Reuse existing breakpoints (640px / 768px).**
The stylesheet already standardizes on `max-width: 640px` and `max-width: 768px`. New utility classes will collapse within these same breakpoints to keep behaviour consistent and avoid a third arbitrary breakpoint.

**Decision: Add a global overflow guard.**
Apply `overflow-x: clip` (with `max-width: 100%`) at the `html, body` level and ensure `img`/embeds default to `max-width: 100%`. This is a safety net so a single stray wide element can never widen the whole page.
*Why over alternatives:* `overflow-x: hidden` on body can break `position: sticky`; `clip` avoids that side effect while still preventing horizontal scroll.

## Risks / Trade-offs

- **Global `overflow-x` could hide an intentionally off-canvas element** → The site has no intentional horizontal-scroll UI except the menu tab bar, which scrolls inside its own container (`.menu-tab-bar`), unaffected by a body-level guard. Verify the tab bar still scrolls after the change.
- **Replacing inline styles may shift desktop spacing slightly** → Mirror the exact gap/column values from the current inline styles into the new classes so desktop rendering is unchanged.
- **Other pages may use the same inline pattern** → Audit `Menu`, `Contact`, `Reservation`, `TakeAway`, and `SeasonalMenu` before finishing, and convert any matching grids.

## Migration Plan

1. Add utility classes and the global overflow guard to `app.css`.
2. Swap inline grid styles in `Home.razor` for the new classes.
3. Grep the remaining pages for `grid-template-columns` inline styles and convert them.
4. Verify at 320px, 375px, 430px, and 768px that no horizontal scroll appears and sections stack correctly.
5. Rollback is a straightforward revert of the CSS/markup edits (no data or config impact).

## Open Questions

- None. Breakpoints, class names, and approach are determined by the existing stylesheet conventions.
