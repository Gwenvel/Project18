class ArtistService {
    constructor($resource) {
        this.artistResource = $resource("http://ws.audioscrobbler.com/2.0/?method=chart.gettopartists&api_key=87bdb2c24f5d7ea2e34ac5d1bdc419f1&format=json&limit=5");
    }

    getArtists() {
        return this.artistResource.query();
    }

    getArtist(id) {
        return this.artistResource.get({ id: id });
    }
}
