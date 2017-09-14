class ArtistService {
    constructor($resource) {
        this.artistResource = $resource("/api/artists:id");
    }

    getArtists() {
        return this.artistResource.query();
    }

    getArtist(id) {
        return this.artistResource.get({ id: id });
    }
}
