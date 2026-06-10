## Why

The current menu page presents all items in a plain list with minimal visual differentiation between sections. A sushi restaurant at this level should convey premium quality — the menu is often the page visitors spend the most time on and the layout directly influences perceived value and conversion to reservations.

## What Changes

- Replace the flat section headings with a more editorial, restaurant-menu style layout
- Add floating/positioned food imagery per section, similar to the reference designs (image alongside items — not as a banner)
- Introduce a two-column item grid for larger screens so sections feel structured and scannable
- Style section titles with a brushstroke/accent treatment (decorative underline or inline icon accent)
- Add a subtle section divider with decorative element between categories
- Improve the `MenuItemCard` layout: item name + dotted leader line + price on same row (classic printed-menu style)
- Add a small category image that floats beside the item list (right-aligned, ~200px, for sections with images)
- Apply a warm off-white/cream tinted background to the menu page body to evoke a printed menu feel
- Improve typography: larger, more authoritative section titles; slightly smaller, more refined item text

## Capabilities

### New Capabilities

- `menu-exclusive-layout`: Two-column item grid, floating section images, dotted-leader-line price rows, cream background, decorative section dividers

### Modified Capabilities

- `menu-page`: Visual redesign of the menu page layout and item card style (no functional/data changes)

## Impact

- `Pages/Menu.razor` — layout wrapper changes
- `Components/Menu/MenuSectionBlock.razor` — section header + image placement rewrite
- `Components/Menu/MenuItemCard.razor` — item row layout (dotted leader + price)
- `wwwroot/css/app.css` — all new/changed component styles
- No data model or service changes required
