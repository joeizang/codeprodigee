export interface PostTags {
  name: string
  tagId: string
}

export interface PostProps {
  postImage?: string
  postBody?: string
  postAuthor?: string
  tags?: PostTags[]
}

export interface BlogPostProps {
  slug: string
}