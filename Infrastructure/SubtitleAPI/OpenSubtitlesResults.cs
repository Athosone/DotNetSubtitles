namespace Infrastructure
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OpenSubtitlesResults
    {
        [JsonProperty("MatchedBy")]
        public string MatchedBy { get; set; }

        [JsonProperty("IDSubMovieFile")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IdSubMovieFile { get; set; }

        [JsonProperty("MovieHash")]
        public string MovieHash { get; set; }

        [JsonProperty("MovieByteSize")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MovieByteSize { get; set; }

        [JsonProperty("MovieTimeMS")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MovieTimeMs { get; set; }

        [JsonProperty("IDSubtitleFile")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IdSubtitleFile { get; set; }

        [JsonProperty("SubFileName")]
        public string SubFileName { get; set; }

        [JsonProperty("SubActualCD")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubActualCd { get; set; }

        [JsonProperty("SubSize")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubSize { get; set; }

        [JsonProperty("SubHash")]
        public string SubHash { get; set; }

        [JsonProperty("SubTSGroup")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? SubTsGroup { get; set; }

        [JsonProperty("InfoReleaseGroup")]
        public string InfoReleaseGroup { get; set; }

        [JsonProperty("InfoFormat")]
        public string InfoFormat { get; set; }

        [JsonProperty("InfoOther")]
        public string InfoOther { get; set; }

        [JsonProperty("IDSubtitle")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IdSubtitle { get; set; }

        [JsonProperty("UserID")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long UserId { get; set; }

        [JsonProperty("SubLanguageID")]
        public string SubLanguageId { get; set; }

        [JsonProperty("SubFormat")]
        public string SubFormat { get; set; }

        [JsonProperty("SubSumCD")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubSumCd { get; set; }

        [JsonProperty("SubAuthorComment")]
        public string SubAuthorComment { get; set; }

        [JsonProperty("SubBad")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubBad { get; set; }

        [JsonProperty("SubRating")]
        public string SubRating { get; set; }

        [JsonProperty("SubSumVotes")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubSumVotes { get; set; }

        [JsonProperty("SubDownloadsCnt")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubDownloadsCnt { get; set; }

        [JsonProperty("MovieReleaseName")]
        public string MovieReleaseName { get; set; }

        [JsonProperty("MovieFPS")]
        public string MovieFps { get; set; }

        [JsonProperty("IDMovie")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IdMovie { get; set; }

        [JsonProperty("IDMovieImdb")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IdMovieImdb { get; set; }

        [JsonProperty("MovieName")]
        public string MovieName { get; set; }

        [JsonProperty("MovieNameEng")]
        public object MovieNameEng { get; set; }

        [JsonProperty("MovieYear")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MovieYear { get; set; }

        [JsonProperty("MovieImdbRating")]
        public string MovieImdbRating { get; set; }

        [JsonProperty("SubFeatured")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubFeatured { get; set; }

        [JsonProperty("UserNickName")]
        public string UserNickName { get; set; }

        [JsonProperty("SubTranslator")]
        public string SubTranslator { get; set; }

        [JsonProperty("ISO639")]
        public string Iso639 { get; set; }

        [JsonProperty("LanguageName")]
        public string LanguageName { get; set; }

        [JsonProperty("SubComments")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubComments { get; set; }

        [JsonProperty("SubHearingImpaired")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubHearingImpaired { get; set; }

        [JsonProperty("UserRank")]
        public string UserRank { get; set; }

        [JsonProperty("SeriesSeason")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SeriesSeason { get; set; }

        [JsonProperty("SeriesEpisode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SeriesEpisode { get; set; }

        [JsonProperty("MovieKind")]
        public string MovieKind { get; set; }

        [JsonProperty("SubHD")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubHd { get; set; }

        [JsonProperty("SeriesIMDBParent")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SeriesImdbParent { get; set; }

        [JsonProperty("SubEncoding")]
        public string SubEncoding { get; set; }

        [JsonProperty("SubAutoTranslation")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubAutoTranslation { get; set; }

        [JsonProperty("SubForeignPartsOnly")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubForeignPartsOnly { get; set; }

        [JsonProperty("SubFromTrusted")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SubFromTrusted { get; set; }

        [JsonProperty("QueryCached")]
        public long QueryCached { get; set; }

        [JsonProperty("SubTSGroupHash", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTsGroupHash { get; set; }

        [JsonProperty("SubDownloadLink")]
        public Uri SubDownloadLink { get; set; }

        [JsonProperty("ZipDownloadLink")]
        public Uri ZipDownloadLink { get; set; }

        [JsonProperty("SubtitlesLink")]
        public Uri SubtitlesLink { get; set; }

        [JsonProperty("QueryNumber")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long QueryNumber { get; set; }

        [JsonProperty("QueryParameters")]
        public QueryParameters QueryParameters { get; set; }

        [JsonProperty("Score")]
        public double Score { get; set; }
    }

    public partial class QueryParameters
    {
        [JsonProperty("moviehash")]
        public string Moviehash { get; set; }

        [JsonProperty("moviebytesize")]
        public long Moviebytesize { get; set; }

        [JsonProperty("episode")]
        public long Episode { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("imdbid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Imdbid { get; set; }

        [JsonProperty("sublanguageid")]
        public string Sublanguageid { get; set; }
    }
}
