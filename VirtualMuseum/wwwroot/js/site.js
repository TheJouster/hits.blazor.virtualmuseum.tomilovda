window.initCarousel = (id) => {
    const el = document.querySelector(`#${id}`);
    if (!el) return;

    new bootstrap.Carousel(el, {
        interval: 2000,
        touch: true,
        ride: false
    });
};