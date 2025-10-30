1. Project setup & scaffolding

   - [x] Create a new .NET MAUI solution targeting MAUI 9.0+ and Android (min API 26).
   - [x] Add a solution-level README with setup and build prerequisites (SDK, workloads, emulator setup).
   - [x] Create projects/folders: App, UI (Views/ViewModels), Services, Models, and Tests.
   - [x] Add initial .gitignore and a basic branching/PR template consistent with `docs/branching-strategy.md`.
   - [x] Commit and push the initial scaffold to a feature branch.

2. Architecture & shared services

   - [x] Add CommunityToolkit.Mvvm package and configure MVVM base classes (BaseViewModel, RelayCommand usage).
   - [x] Configure dependency injection (Microsoft.Extensions.DependencyInjection) in app startup.
   - [x] Create a navigation service abstraction and register it with DI.
   - [x] Implement an API client/service layer interface (IApiClient) and a placeholder HTTP implementation.
   - [x] Define core domain models and DTOs for List, Detail, and Data Entry flows.
   - [x] Add logging and global error handling hooks (simple logger service and error display strategy).

3. Design system & theming

   - [x] Create `Resources/Styles.xaml` and add color, typography, padding, and radius tokens from `docs/requirements.md`.
   - [x] Add a light theme resource dictionary using Primary #2196F3, Background #FAFAFA, Text colors, and status colors.
   - [x] Create reusable styles for headers, body text, labels, buttons, and inputs that match typography spec.
   - [x] Implement UI components: KPI card, status dot, list item template, sticky footer, FAB, primary button.
   - [x] Add accessibility attributes to components (AutomationIds, semantic labels) and ensure 44pt touch target sizing.

4. Shell navigation & bottom tabs

   - [ ] Implement `AppShell` with bottom tabs (max 5 tabs) and define routes for Dashboard, Lists, Settings, etc.
   - [ ] Wire up empty pages for each tab (DashboardPage, ListPage, DetailPage, DataEntryPage) and register routes.
   - [ ] Ensure route-based navigation supports pushing/popping from List -> Detail -> Edit and deep linking.

5. Dashboard screen

   - [ ] Implement `DashboardViewModel` with properties for KPIs and recent items.
   - [ ] Implement `DashboardPage` layout: header (Welcome + user name), KPI card grid, recent items CollectionView, and FAB.
   - [ ] Hook FAB to a command in the ViewModel that navigates to Data Entry for new item creation.
   - [ ] Add unit tests for `DashboardViewModel` (initial data population and FAB command behavior).

6. List View

   - [ ] Implement `ListViewModel` supporting: items collection, search query, filters, and paging/loading states.
   - [ ] Create `ListPage` with SearchBar, filter controls, and a CollectionView using the list item template (primary + 2 secondary lines, status dot, chevron).
   - [ ] Implement real-time search filtering in the ViewModel (search throttle/debounce) and test it.
   - [ ] Add pagination or incremental loading to the CollectionView for large data sets.
   - [ ] Add unit tests for `ListViewModel` (search/filter logic, paging trigger).

7. Detail View

   - [ ] Implement `DetailViewModel` that loads item details by ID and exposes commands for primary action and menu actions.
   - [ ] Create `DetailPage` with header (Title + ID), vertical stacked sections, and sticky footer containing primary action and overflow menu.
   - [ ] Ensure navigation back to list preserves scroll position when appropriate.
   - [ ] Add unit tests for `DetailViewModel` (loading, error handling, action commands).

8. Data Entry (Create/Edit)

   - [ ] Implement `DataEntryViewModel` with bindable properties for each form field, validation rules, and Submit/Cancel commands.
   - [ ] Create `DataEntryPage` with VerticalStackLayout, Entry controls, Pickers, Scan Barcode button, and a sticky Submit/Cancel footer.
   - [ ] Implement client-side validation and display inline errors in the UI.
   - [ ] Add unit tests for `DataEntryViewModel` (validation and submit behavior).

9. Barcode scanning integration

   - [ ] Evaluate and select a MAUI-compatible barcode scanning library (e.g., ZXing.Net.MAUI) that supports MAUI 9.
   - [ ] Add camera permissions handling and a small permission UX flow (request, rationale, fallback to manual entry).
   - [ ] Implement Scan Barcode flow integrated with `DataEntryViewModel` to populate fields on successful scan.
   - [ ] Add tests or manual verification checklist for scanning on representative Android API levels.

10. Platform polish, accessibility & responsive testing

   - [ ] Verify and adjust touch target sizes to ensure 44pt minimum across components.
   - [ ] Run color contrast checks and adjust styles to meet accessibility recommendations.
   - [ ] Test layouts on representative emulators/devices (small phone, medium/large phones, tablet, foldable) and fix layout breakages.
   - [ ] Add accessibility labels and test using screen reader tools where possible.

11. Offline support & sync (optional)

   - [ ] Decide whether offline caching is required based on backend availability requirements.
   - [ ] If required: add local storage layer (SQLite) and repository abstractions for read/write operations.
   - [ ] Implement a basic sync strategy: background sync, conflict resolution policy, and retry/backoff.
   - [ ] Add integration tests for local read/write and sync logic (where feasible).

12. Testing, CI/CD and release

   - [ ] Add unit test framework and write unit tests for ViewModels and services (cover happy path + common edge cases).
   - [ ] Create a GitHub Actions workflow to build the MAUI Android artifact and run unit tests.
   - [ ] Add a smoke/integration job (emulator-based) to validate app starts and main navigation flows.
   - [ ] Plan for instrumented UI tests (Appium or App Center) and add a tracking task to onboard device/cloud test service.

13. Final acceptance & polish

   - [ ] Validate each acceptance criterion from `docs/requirements.md` on representative devices.
   - [ ] Fix outstanding UI/UX issues, performance hotspots, and accessibility gaps.
   - [ ] Prepare release notes and a short testing matrix describing tested devices and known limitations.
   - [ ] Merge feature branches and tag a release candidate once acceptance is met.

14. Documentation & handover

   - [ ] Update `README.md` with local development steps, emulator setup, and build instructions.
   - [ ] Document architecture decisions, DI registrations, and component usage in `docs/`.
   - [ ] Provide a short demo script and checklist for QA to validate acceptance criteria.
