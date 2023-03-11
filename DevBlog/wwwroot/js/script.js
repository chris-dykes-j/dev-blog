
const getPreference = () => {
    const preference = localStorage.getItem("theme");
    document.body.style.transition ="all 0s";
    if (preference === "dark")
        document.body.classList.toggle("dark-theme");
    else
        document.body.classList.toggle("light-theme");
}

getPreference();

const savePreference = (theme) => {
    localStorage.setItem("theme", theme);
}

const toggleDark = () => {
    document.body.style.transition ="all .6s";
    if (document.body.classList.toggle("light-theme")) {
        savePreference("light");
    } else {
        savePreference("dark");
    }
}