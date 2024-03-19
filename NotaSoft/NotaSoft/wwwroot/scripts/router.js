const handleNavSideStyles = () => {
    const path = window.location.pathname;
    $('.nav-link').each(function () {
        $(this).removeClass("active")
        var href = $(this).find("a").attr("href")

        console.log(href)
        console.log(path)

        if (href == path) {
            $(this).addClass("active")
        } else if (href == "#/" && path == "") {
            $(this).addClass("active")
        }
    });
}
