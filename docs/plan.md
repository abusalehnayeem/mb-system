## Mobile ERP UI Implementation Plan (MAUI)

### Short overview

Build a cross-platform mobile ERP UI using .NET MAUI (9.0+) targeting Android 8.0+ with a light blue/white theme and native mobile patterns. The app will use Shell with bottom tabs, follow the provided design system (colors, typography, touch targets), and implement core screens: Dashboard, List View, Detail View, and Data Entry (including barcode scanning). Acceptance criteria are the checklist items in `docs/requirements.md` (rendering, bottom nav, FAB, search, theme, touch targets).

### High-level phases

1. Project setup & scaffolding (1-2 days)
	- Create a MAUI solution configured for MAUI 9 and Android (min API 26).
	- Add project structure: Projects for App, UI (Views/ViewModels), Services, Models, and Tests.
	- Configure source control best-practices (branching, PR template).

2. Architecture & shared services (2-3 days)
	- Choose app architecture: MVVM (CommunityToolkit.Mvvm) with dependency injection (Microsoft.Extensions.DependencyInjection).
	- Define shared app services: navigation, API client/service layer, local storage (SQLite/Preferences), logging, and error handling.
	- Define models representing core ERP entities and DTOs for API mapping.

3. Design system & theming (1-2 days)
	- Implement color palette, typography styles, common styles, and layout tokens (padding, radii, touch target sizes) centrally (Resources/Styles.xaml).
	- Create reusable components: KPI card, status dot, List item template, Sticky footer, FAB, Primary button, SearchBar and Filter controls.

4. Shell navigation & bottom tabs (1 day)
	- Implement Shell with bottom tabs up to 5 items; configure routes and route-based navigation for List -> Detail -> Edit flows.

5. Core screens implementation (5-8 days)
	- Dashboard: KPI cards (responsive grid), recent items list, FAB triggering new action.
	- List View: SearchBar + real-time filter, CollectionView template with two secondary lines, status dot and chevron. Support paging or virtualization for large lists.
	- Detail View: Header with title + ID, vertical stacked sections, sticky footer with primary action and menu.
	- Data Entry: Form layout, Entry and Picker controls, Scan Barcode button and Submit/Cancel actions. Validate inputs and show inline errors.

6. Barcode scanning integration (2 days)
	- Integrate a maintained MAUI barcode library (e.g., ZXing.Net.MAUI or equivalent) and implement camera permissions, scanning UI, and fallback (manual entry).

7. Platform polish, accessibility, responsive & device testing (3-4 days)
	- Ensure touch targets are >= 44pt, color contrast and typography match spec, large/small device layout adjustments.
	- Test on representative devices (phones, large phones, tablets, foldables via emulator) and adjust breakpoints.

8. Offline support & sync (optional, 3-5 days)
	- If needed, implement local caching (SQLite or file) and a basic sync strategy (background sync, conflict policy). This is scoped as optional depending on backend requirements.

9. Testing, CI/CD and release (2-4 days)
	- Unit tests for ViewModels and services (xUnit / MSTest), integration tests for services.
	- Instrumented UI tests: consider Appium or cloud device testing (Microsoft App Center) for end-to-end flows.
	- CI pipeline (GitHub Actions): build, run unit tests, produce Android artifacts and run emulator-based smoke tests.

10. Final acceptance & polish (1-2 days)
	- Verify acceptance checklist (rendering, nav, FAB, search filters, theme, touch targets).
	- Apply performance optimizations and final UX tweaks.

### Deliverables

- Working MAUI app implementing Dashboard, List, Detail, and Data Entry flows.
- Centralized design system and reusable UI components.
- Unit tests and a basic CI workflow to build and test Android artifacts.
- Documentation: `docs/plan.md` (this file), README with setup instructions, and a brief testing matrix.

### Dependencies

- .NET SDK and MAUI workloads compatible with MAUI 9.0+ (Visual Studio 2022/2023 with MAUI support or Visual Studio 2022/2023 Preview as appropriate).
- Android SDK (API 26+), emulator images for representative devices.
- CommunityToolkit.MVVM (or equivalent) for MVVM helpers.
- Barcode scanning library such as ZXing.Net.MAUI (verify compatibility with MAUI 9) or another maintained alternative.
- HTTP client library (System.Net.Http) and JSON serializer (System.Text.Json / Newtonsoft.Json) for backend APIs.
- SQLite-net or Entity Framework Core (if local DB needed) for caching/sync storage.
- CI (GitHub Actions) and optionally App Center / cloud device farm for UI testing across devices.

### Risks & considerations

- MAUI version compatibility: MAUI 9.0+ implies newer runtimes—verify SDK/tooling compatibility early. Build tooling and emulator support can differ across VS versions.
- Device fragmentation: wide screen sizes and foldables require careful responsive layout testing; emulators may not perfectly match real devices.
- Third-party library maturity: confirm maintenance and MAUI 9 compatibility for barcode and other native-interop libraries.
- Performance on older Android devices: MAUI apps can have larger binary sizes and memory usage; optimize images and reduce work on the UI thread.
- Camera & permissions: runtime permission handling differs across Android versions; implement graceful permissions UX and fallbacks.
- Offline/sync complexity: syncing ERP data reliably is a complex domain—clarify requirements before implementing full sync.

### Acceptance criteria (mapped to `docs/requirements.md`)

- All screens render correctly across representative devices and screen sizes.
- Bottom navigation works with up to 5 items and correct route behavior.
- FAB triggers the primary "new" action from Dashboard and contextual screens.
- Search filters in List View operate in real-time and combine with filters.
- App theme matches blue/white design tokens and typography specs.
- Touch targets are at least 44pt and UI components respect spacing and radii.

### Estimation summary (rough, for a small team of 1-2 experienced MAUI devs)

- Project bootstrap & architecture: 3-5 days
- Core UI and components: 6-10 days
- Barcode & platform integrations: 2-3 days
- Testing & CI/CD: 3-5 days
- Polishing and acceptance: 2-3 days

Total: ~16–26 working days (depending on unknowns like backend readiness and offline requirements).

### Next steps

1. Confirm platform & SDK version to target (exact MAUI/.NET version and Visual Studio version).
2. Confirm backend API endpoints, authentication, and required payloads for List/Detail/Data Entry flows.
3. Create the MAUI solution scaffold and push an initial commit with empty navigation and theming resources.
4. Begin implementation following the phased plan above, starting with project scaffolding and design tokens.

---

Prepared from the requirements in `docs/requirements.md` (Mobile ERP UI Spec - MAUI).

