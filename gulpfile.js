const { src, dest, watch, series } = require("gulp");
const sass = require("gulp-sass")(require("sass"));

// Compile SCSS to CSS
function buildStyles() {
    return src("wwwroot/scss/main.scss")  // Source folder
        .pipe(sass().on("error", sass.logError)) // Compile Sass
        .pipe(dest("wwwroot/css")); // Output folder
}

// Watch task
function watchTask() {
    watch(["wwwroot/scss/**/*.scss"], buildStyles);
}

exports.default = series(buildStyles, watchTask);
