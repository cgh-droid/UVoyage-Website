function setVariables() {
    ["mathDone", "scienceDone", "englishDone", "socialStudiesDone", "mathGood", "englishGood", "socialStudiesGood"]
        .forEach(key => {
            if (localStorage.getItem(key) === null) {
                localStorage.setItem(key, "false");
            }
        });
}
document.addEventListener("DOMContentLoaded", setVariables());
