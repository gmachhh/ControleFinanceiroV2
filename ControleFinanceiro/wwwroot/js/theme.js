const body = document.body;

const savedTheme = localStorage.getItem("theme");

const themeButton =
    document.getElementById("themeButton");

const settingsThemeButton =
    document.getElementById("settingsThemeButton");


function applyTheme(theme) {

    if (theme === "dark") {

        body.classList.add("dark-mode");

    } else {

        body.classList.remove("dark-mode");

    }

}


function updateThemeButtons() {

    const isDark =
        body.classList.contains("dark-mode");


    if (themeButton) {

        themeButton.innerHTML = isDark

            ? '<i class="fa-solid fa-sun"></i>'

            : '<i class="fa-solid fa-moon"></i>';

    }


    if (settingsThemeButton) {

        settingsThemeButton.innerHTML = isDark

            ? '<i class="fa-solid fa-sun"></i> Tema claro'

            : '<i class="fa-solid fa-moon"></i> Tema escuro';

    }

}


applyTheme(savedTheme);

updateThemeButtons();


function toggleTheme() {

    const isDark =
        body.classList.contains("dark-mode");

    const newTheme =
        isDark ? "light" : "dark";

    localStorage.setItem(
        "theme",
        newTheme
    );

    applyTheme(newTheme);

    updateThemeButtons();

}


if (themeButton) {

    themeButton.addEventListener(
        "click",
        toggleTheme
    );

}


if (settingsThemeButton) {

    settingsThemeButton.addEventListener(
        "click",
        toggleTheme
    );

}