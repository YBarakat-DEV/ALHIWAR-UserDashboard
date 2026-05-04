function loadHmsTheme() {

    /*COLOR*/
    const primary = localStorage.getItem("hms-primary") || "#09466e";
    const accent = localStorage.getItem("hms-accent") || "#fa1911";
    const dark = localStorage.getItem("hms-dark") === "true";
    document.documentElement.style.setProperty("--hms-primary", primary);
    document.documentElement.style.setProperty("--hms-accent", accent);

    if (dark) {
        document.documentElement.setAttribute("data-theme", "dark");
    } else {
        document.documentElement.removeAttribute("data-theme");
    }
}
function saveHmsTheme(primary, accent, dark) {
    localStorage.setItem("hms-primary", primary);
    localStorage.setItem("hms-accent", accent);
    localStorage.setItem("hms-dark", dark ? "true" : "false");
    loadHmsTheme();
}
loadHmsTheme();